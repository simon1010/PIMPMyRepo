using Mercurial;
using System.IO;

namespace PIMPMyRepos
{
  public class MercurialService
  {
    private static readonly MercurialService instance = new MercurialService();

    private MercurialService()
    {
    }

    public static MercurialService Instance
    {
      get
      {
        return instance;
      }
    }

    public bool isRepo(string selectedPath)
    {
      var hgFolderPath = selectedPath + "\\.hg";
      return Directory.Exists(hgFolderPath);
    }

    public void pull(string repoPath)
    {
      Repository repo = new Repository(repoPath);
      PullCommand pullCommand = new PullCommand();
      pullCommand.Timeout = 60 * 10; // 10 minutes
      repo.Pull(pullCommand);
    }
  }
}
