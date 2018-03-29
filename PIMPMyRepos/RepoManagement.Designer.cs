namespace PIMPMyRepos
{
  partial class RepoManagement
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.RepoPathTextBox = new System.Windows.Forms.TextBox();
      this.AddButton = new System.Windows.Forms.Button();
      this.BrowseButton = new System.Windows.Forms.Button();
      this.RepoListListbox = new System.Windows.Forms.ListBox();
      this.RemoveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // RepoPathTextBox
      // 
      this.RepoPathTextBox.Location = new System.Drawing.Point(12, 12);
      this.RepoPathTextBox.Name = "RepoPathTextBox";
      this.RepoPathTextBox.Size = new System.Drawing.Size(988, 20);
      this.RepoPathTextBox.TabIndex = 0;
      // 
      // AddButton
      // 
      this.AddButton.Location = new System.Drawing.Point(929, 45);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(75, 23);
      this.AddButton.TabIndex = 1;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // BrowseButton
      // 
      this.BrowseButton.Location = new System.Drawing.Point(929, 74);
      this.BrowseButton.Name = "BrowseButton";
      this.BrowseButton.Size = new System.Drawing.Size(75, 23);
      this.BrowseButton.TabIndex = 2;
      this.BrowseButton.Text = "Browse";
      this.BrowseButton.UseVisualStyleBackColor = true;
      this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
      // 
      // RepoListListbox
      // 
      this.RepoListListbox.FormattingEnabled = true;
      this.RepoListListbox.Location = new System.Drawing.Point(12, 45);
      this.RepoListListbox.Name = "RepoListListbox";
      this.RepoListListbox.Size = new System.Drawing.Size(911, 199);
      this.RepoListListbox.TabIndex = 3;
      // 
      // RemoveButton
      // 
      this.RemoveButton.Location = new System.Drawing.Point(929, 221);
      this.RemoveButton.Name = "RemoveButton";
      this.RemoveButton.Size = new System.Drawing.Size(75, 23);
      this.RemoveButton.TabIndex = 4;
      this.RemoveButton.Text = "Remove";
      this.RemoveButton.UseVisualStyleBackColor = true;
      this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
      // 
      // RepoManagement
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 257);
      this.Controls.Add(this.RemoveButton);
      this.Controls.Add(this.RepoListListbox);
      this.Controls.Add(this.BrowseButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.RepoPathTextBox);
      this.Name = "RepoManagement";
      this.Text = "RepoManagement";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox RepoPathTextBox;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button BrowseButton;
    private System.Windows.Forms.ListBox RepoListListbox;
    private System.Windows.Forms.Button RemoveButton;
  }
}

