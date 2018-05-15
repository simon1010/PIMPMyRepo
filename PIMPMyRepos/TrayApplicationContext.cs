using PIMPMyRepos.Properties;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PIMPMyRepos
{
  class TrayApplicationContext : ApplicationContext
  {
    private NotifyIcon trayIcon;
    private System.Windows.Forms.Timer pullTimer;
    private MercurialService mercurialService = MercurialService.Instance;
    private Thread notificatinThread;

    public TrayApplicationContext()
    {
      // Initialize Tray Icon
      trayIcon = new NotifyIcon();
      trayIcon.Icon = Resources.AppIcon;
      trayIcon.ContextMenu = new ContextMenu(
      new MenuItem[] 
      {
        new MenuItem("Settings", ManageRepos),
        new MenuItem("Exit", Exit)
      });
      trayIcon.Visible = true;

      UpdateTrayStatus();

      InitTimer();
      
      TestRepos();
    }

    public void InitTimer()
    {
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();
      pullTimer = new System.Windows.Forms.Timer();
      pullTimer.Tick += new EventHandler(PullLoop);
      pullTimer.Interval = settings.pullInterval * 60 * 1000; // in miliseconds
    }

    void UpdateAndRestartTimer(PIMPMyRepoSettings settings)
    {
      Debug.Assert(pullTimer != null);

      pullTimer.Stop();
      pullTimer.Interval = settings.pullInterval * 60 * 1000;
      pullTimer.Start();
    }

    void UpdateTrayStatus()
    {
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();
      trayIcon.Text = String.Format("Pull into {0} repos, every {1} minutes ", settings.repoCount.ToString(), settings.pullInterval);
    }

    void TestRepos()
    {
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();
      if (settings.repoCount == 0)
      {
        ManageRepos(null, null);
      }
      pullTimer.Start();
    }

    void ShowTrayNotification()
    {
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();

      trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      trayIcon.BalloonTipTitle = "Pulling into repos";
      trayIcon.BalloonTipText = String.Format("Nr of repos being pulled into: {0}", settings.repoCount.ToString());

      // Display for 5 seconds.
      trayIcon.ShowBalloonTip(5000);
    }


    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    public void WaitForHGWorkbenchToLoseFocus()
    {
      while (true)
      {
        Process[] p = Process.GetProcessesByName("thgw");
        if (p.Length > 0)
        {
          if (!p[0].MainWindowHandle.Equals(GetForegroundWindow()))
          {
            break;
          }
        }
        Thread.Sleep(5000);
      }
    }

    void PullLoop(object sender, EventArgs e)
    {
      UpdateTrayStatus();
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();

      if(notificatinThread != null)
      {
        notificatinThread.Join();
      }

      WaitForHGWorkbenchToLoseFocus();
      pullTimer.Stop();

      notificatinThread = new Thread(ShowTrayNotification);
      notificatinThread.Start();
      
      foreach (var repo in settings.repoPaths)
      {
        mercurialService.pull(repo);
      }

      pullTimer.Start();
    }

    void ManageRepos(object sender, EventArgs e)
    {
      PIMPMyRepoSettings settings = PIMPMyRepoSettings.Load();
      RepoManagement repoPathDialog = new RepoManagement(settings);
      var result = repoPathDialog.ShowDialog();

      settings.ResetSettings();

      var pullInterval = repoPathDialog.GetPullInterval();
      if (pullInterval != settings.pullInterval)
      {
        settings.pullInterval = pullInterval;
        UpdateAndRestartTimer(settings);
      }

      var paths = repoPathDialog.GetListBoxItems();
      foreach (string path in paths)
      {
        settings.repoPaths.Add(path);
        settings.repoCount++;
      }

      settings.Save();
      repoPathDialog.Dispose();
      UpdateTrayStatus();
    }

    void Exit(object sender, EventArgs e)
    {
      // Hide tray icon, otherwise it will remain shown until user mouses over it
      trayIcon.Visible = false;
      
      // In case someone decides to close tha application whilst the baloon pop-up is being shown
      if (notificatinThread != null)
      {
        notificatinThread.Join();
      }

      pullTimer.Stop();
      Application.Exit();
    }
  }
}
