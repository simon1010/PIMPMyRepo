using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace PIMPMyRepos
{
  public class PIMPMyRepoSettings : AppSettings<PIMPMyRepoSettings>
  {
    public int repoCount = 0;
    public List<string> repoPaths = new List<string>();
    public int pullInterval = 10;

    public void ResetSettings()
    {
      repoCount = 0;
      repoPaths.Clear();
    }
  }

  public class AppSettings<T> where T : new()
  {
    private const string DEFAULT_FILENAME = "settings.json";

    public void Save(string fileName = DEFAULT_FILENAME)
    {
      File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
    }

    public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
    {
      File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
    }

    public static T Load(string fileName = DEFAULT_FILENAME)
    {
      T t = new T();
      if (File.Exists(fileName))
        t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
      return t;
    }
  }
}
