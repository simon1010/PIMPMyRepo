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
      this.RepositoriesGroupBox = new System.Windows.Forms.GroupBox();
      this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
      this.MinutesLabel = new System.Windows.Forms.Label();
      this.PullIntervalTextBox = new System.Windows.Forms.TextBox();
      this.PullIntervalLabel = new System.Windows.Forms.Label();
      this.RepositoriesGroupBox.SuspendLayout();
      this.SettingsGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // RepoPathTextBox
      // 
      this.RepoPathTextBox.Location = new System.Drawing.Point(6, 26);
      this.RepoPathTextBox.Name = "RepoPathTextBox";
      this.RepoPathTextBox.Size = new System.Drawing.Size(911, 20);
      this.RepoPathTextBox.TabIndex = 0;
      // 
      // AddButton
      // 
      this.AddButton.Location = new System.Drawing.Point(923, 59);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(75, 23);
      this.AddButton.TabIndex = 1;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // BrowseButton
      // 
      this.BrowseButton.Location = new System.Drawing.Point(923, 26);
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
      this.RepoListListbox.Location = new System.Drawing.Point(6, 59);
      this.RepoListListbox.Name = "RepoListListbox";
      this.RepoListListbox.Size = new System.Drawing.Size(911, 199);
      this.RepoListListbox.TabIndex = 3;
      // 
      // RemoveButton
      // 
      this.RemoveButton.Location = new System.Drawing.Point(923, 88);
      this.RemoveButton.Name = "RemoveButton";
      this.RemoveButton.Size = new System.Drawing.Size(75, 23);
      this.RemoveButton.TabIndex = 4;
      this.RemoveButton.Text = "Remove";
      this.RemoveButton.UseVisualStyleBackColor = true;
      this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
      // 
      // RepositoriesGroupBox
      // 
      this.RepositoriesGroupBox.Controls.Add(this.RemoveButton);
      this.RepositoriesGroupBox.Controls.Add(this.RepoListListbox);
      this.RepositoriesGroupBox.Controls.Add(this.RepoPathTextBox);
      this.RepositoriesGroupBox.Controls.Add(this.BrowseButton);
      this.RepositoriesGroupBox.Controls.Add(this.AddButton);
      this.RepositoriesGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
      this.RepositoriesGroupBox.Location = new System.Drawing.Point(12, 83);
      this.RepositoriesGroupBox.Name = "RepositoriesGroupBox";
      this.RepositoriesGroupBox.Size = new System.Drawing.Size(1012, 264);
      this.RepositoriesGroupBox.TabIndex = 5;
      this.RepositoriesGroupBox.TabStop = false;
      this.RepositoriesGroupBox.Text = "Repositories";
      // 
      // SettingsGroupBox
      // 
      this.SettingsGroupBox.Controls.Add(this.MinutesLabel);
      this.SettingsGroupBox.Controls.Add(this.PullIntervalTextBox);
      this.SettingsGroupBox.Controls.Add(this.PullIntervalLabel);
      this.SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
      this.SettingsGroupBox.Name = "SettingsGroupBox";
      this.SettingsGroupBox.Size = new System.Drawing.Size(1012, 65);
      this.SettingsGroupBox.TabIndex = 6;
      this.SettingsGroupBox.TabStop = false;
      this.SettingsGroupBox.Text = "Settings";
      // 
      // MinutesLabel
      // 
      this.MinutesLabel.AutoSize = true;
      this.MinutesLabel.Location = new System.Drawing.Point(923, 32);
      this.MinutesLabel.Name = "MinutesLabel";
      this.MinutesLabel.Size = new System.Drawing.Size(44, 13);
      this.MinutesLabel.TabIndex = 2;
      this.MinutesLabel.Text = "Minutes";
      // 
      // PullIntervalTextBox
      // 
      this.PullIntervalTextBox.Location = new System.Drawing.Point(127, 29);
      this.PullIntervalTextBox.Name = "PullIntervalTextBox";
      this.PullIntervalTextBox.Size = new System.Drawing.Size(790, 20);
      this.PullIntervalTextBox.TabIndex = 1;
      this.PullIntervalTextBox.TextChanged += new System.EventHandler(this.PullIntervalTextBox_TextChanged);
      // 
      // PullIntervalLabel
      // 
      this.PullIntervalLabel.AutoSize = true;
      this.PullIntervalLabel.Location = new System.Drawing.Point(7, 29);
      this.PullIntervalLabel.Name = "PullIntervalLabel";
      this.PullIntervalLabel.Size = new System.Drawing.Size(61, 13);
      this.PullIntervalLabel.TabIndex = 0;
      this.PullIntervalLabel.Text = "Pull interval";
      // 
      // RepoManagement
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1036, 358);
      this.Controls.Add(this.SettingsGroupBox);
      this.Controls.Add(this.RepositoriesGroupBox);
      this.Name = "RepoManagement";
      this.Text = "RepoManagement";
      this.RepositoriesGroupBox.ResumeLayout(false);
      this.RepositoriesGroupBox.PerformLayout();
      this.SettingsGroupBox.ResumeLayout(false);
      this.SettingsGroupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.TextBox RepoPathTextBox;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button BrowseButton;
    private System.Windows.Forms.ListBox RepoListListbox;
    private System.Windows.Forms.Button RemoveButton;
    private System.Windows.Forms.GroupBox RepositoriesGroupBox;
    private System.Windows.Forms.GroupBox SettingsGroupBox;
    private System.Windows.Forms.TextBox PullIntervalTextBox;
    private System.Windows.Forms.Label PullIntervalLabel;
    private System.Windows.Forms.Label MinutesLabel;
  }
}

