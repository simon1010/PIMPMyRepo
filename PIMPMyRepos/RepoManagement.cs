using PIMPMyRepos.Properties;
using System;
using System.Windows.Forms;

namespace PIMPMyRepos
{
  public partial class RepoManagement : Form
  {
    MercurialService mercurialService = MercurialService.Instance;
    private ErrorProvider errorProvider;

    public RepoManagement(PIMPMyRepoSettings settings)
    {
      InitializeComponent();
      // set our icon
      Icon = Resources.AppIcon;

      // Disallow resize
      MaximizeBox = false;
      MinimizeBox = false;

      // Field validation
      errorProvider = new ErrorProvider(this);

      // Init from stored settings
      RepoListListbox.Items.AddRange(settings.repoPaths.ToArray());
      PullIntervalTextBox.Text = settings.pullInterval.ToString();
    }

    public ListBox.ObjectCollection GetListBoxItems()
    {
      return RepoListListbox.Items;
    }

    public int GetPullInterval()
    {
      return int.Parse(PullIntervalTextBox.Text);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
      if(!string.IsNullOrWhiteSpace(RepoPathTextBox.Text))
        RepoListListbox.Items.Add(RepoPathTextBox.Text);
      RepoPathTextBox.Text = "";
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
      using (var fbd = new FolderBrowserDialog())
      {
        DialogResult result = fbd.ShowDialog();
        var selectedPath = fbd.SelectedPath;
        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectedPath))
        {
          if(mercurialService.isRepo(selectedPath))
            RepoPathTextBox.Text = selectedPath;
          else
            MessageBox.Show("Folder in not a Mercurial repository! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
      if(RepoListListbox.Items.Count > 0)
        RepoListListbox.Items.Remove(RepoListListbox.Items[RepoListListbox.SelectedIndex]);
    }

    private void PullIntervalTextBox_TextChanged(object sender, EventArgs e)
    {
      if (!int.TryParse(PullIntervalTextBox.Text, out int result))
      {
        errorProvider.SetError(PullIntervalTextBox, "must contain an integer value");
      }
      else
      {
        errorProvider.Clear();
      }
    }

    private void RepoListListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      //string selectedPath = RepoListListbox.
    }
  }
}
