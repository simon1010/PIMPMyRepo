using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMPMyRepos
{
  public partial class RepoManagement : Form
  {
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
      RepoListListbox.Items.Add(RepoPathTextBox.Text);
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
      using (var fbd = new FolderBrowserDialog())
      {
        DialogResult result = fbd.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
          RepoPathTextBox.Text = fbd.SelectedPath;
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
