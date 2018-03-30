using System;
using System.Windows.Forms;

namespace PIMPMyRepos
{
  public partial class RepoManagement : Form
  {
    MercurialService mercurialService = MercurialService.Instance;

    public RepoManagement(PIMPMyRepoSettings settings)
    {
      InitializeComponent();
      RepoListListbox.Items.AddRange(settings.repoPaths.ToArray());
    }

    public ListBox.ObjectCollection GetListBoxItems()
    {
      return RepoListListbox.Items;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
      if(!string.IsNullOrWhiteSpace(RepoPathTextBox.Text))
        RepoListListbox.Items.Add(RepoPathTextBox.Text);
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
  }
}
