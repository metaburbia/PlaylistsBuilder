namespace PlaylistsBuilder
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToITunesXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.lbPlayLists = new System.Windows.Forms.ListBox();
            this.cbSelectiTunes = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtItunesPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConvert = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadPlaylists = new System.Windows.Forms.Button();
            this.btnCopyToConvert = new System.Windows.Forms.Button();
            this.btnCopyToPlaylists = new System.Windows.Forms.Button();
            this.cbSelectConvert = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.progressConvert = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.xmlFilePathDlg = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToITunesXMLFileToolStripMenuItem,
            this.outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pathToITunesXMLFileToolStripMenuItem
            // 
            this.pathToITunesXMLFileToolStripMenuItem.Name = "pathToITunesXMLFileToolStripMenuItem";
            this.pathToITunesXMLFileToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.pathToITunesXMLFileToolStripMenuItem.Text = "Path to iTunes XML File";
            // 
            // outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem
            // 
            this.outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem.Name = "outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem";
            this.outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem.Text = "Output folder for Logitch Media Server playlists";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(320, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fbDlg
            // 
            this.fbDlg.Description = "Output location for your converted playlists";
            // 
            // lbPlayLists
            // 
            this.lbPlayLists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlayLists.FormattingEnabled = true;
            this.lbPlayLists.Location = new System.Drawing.Point(11, 151);
            this.lbPlayLists.Name = "lbPlayLists";
            this.tableLayoutPanel1.SetRowSpan(this.lbPlayLists, 2);
            this.lbPlayLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPlayLists.Size = new System.Drawing.Size(442, 340);
            this.lbPlayLists.TabIndex = 12;
            // 
            // cbSelectiTunes
            // 
            this.cbSelectiTunes.AutoSize = true;
            this.cbSelectiTunes.Location = new System.Drawing.Point(11, 498);
            this.cbSelectiTunes.Name = "cbSelectiTunes";
            this.cbSelectiTunes.Size = new System.Drawing.Size(145, 17);
            this.cbSelectiTunes.TabIndex = 13;
            this.cbSelectiTunes.Text = "Select All iTunes Playlists";
            this.cbSelectiTunes.UseVisualStyleBackColor = true;
            this.cbSelectiTunes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Controls.Add(this.lbPlayLists, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtItunesPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbConvert, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadPlaylists, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyToConvert, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyToPlaylists, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbSelectConvert, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbSelectiTunes, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnConvert, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressConvert, 3, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 593);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtItunesPath
            // 
            this.txtItunesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtItunesPath, 3);
            this.txtItunesPath.Location = new System.Drawing.Point(11, 24);
            this.txtItunesPath.Name = "txtItunesPath";
            this.txtItunesPath.Size = new System.Drawing.Size(930, 20);
            this.txtItunesPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder for Logitech Media Server  playlist files";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(947, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "All Playlists";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SelectOutputPath);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtFolder, 3);
            this.txtFolder.Location = new System.Drawing.Point(11, 72);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(930, 20);
            this.txtFolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location of iTunes XML file";
            // 
            // lbConvert
            // 
            this.lbConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConvert.FormattingEnabled = true;
            this.lbConvert.Location = new System.Drawing.Point(499, 151);
            this.lbConvert.Name = "lbConvert";
            this.tableLayoutPanel1.SetRowSpan(this.lbConvert, 2);
            this.lbConvert.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbConvert.Size = new System.Drawing.Size(442, 340);
            this.lbConvert.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Playlists to convert";
            // 
            // btnLoadPlaylists
            // 
            this.btnLoadPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPlaylists.Location = new System.Drawing.Point(833, 99);
            this.btnLoadPlaylists.Name = "btnLoadPlaylists";
            this.btnLoadPlaylists.Size = new System.Drawing.Size(108, 25);
            this.btnLoadPlaylists.TabIndex = 0;
            this.btnLoadPlaylists.Text = "Load Playlists";
            this.toolTip1.SetToolTip(this.btnLoadPlaylists, "Load playlists from the iTunes file");
            this.btnLoadPlaylists.UseVisualStyleBackColor = true;
            this.btnLoadPlaylists.Click += new System.EventHandler(this.click_loadPlaylists);
            // 
            // btnCopyToConvert
            // 
            this.btnCopyToConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyToConvert.Location = new System.Drawing.Point(459, 151);
            this.btnCopyToConvert.Name = "btnCopyToConvert";
            this.btnCopyToConvert.Size = new System.Drawing.Size(34, 33);
            this.btnCopyToConvert.TabIndex = 15;
            this.btnCopyToConvert.Text = ">>";
            this.toolTip1.SetToolTip(this.btnCopyToConvert, "Copy to conversion window");
            this.btnCopyToConvert.UseVisualStyleBackColor = true;
            this.btnCopyToConvert.Click += new System.EventHandler(this.btnCopyToConvert_Click);
            // 
            // btnCopyToPlaylists
            // 
            this.btnCopyToPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyToPlaylists.Location = new System.Drawing.Point(459, 191);
            this.btnCopyToPlaylists.Name = "btnCopyToPlaylists";
            this.btnCopyToPlaylists.Size = new System.Drawing.Size(34, 33);
            this.btnCopyToPlaylists.TabIndex = 16;
            this.btnCopyToPlaylists.Text = "<<";
            this.toolTip1.SetToolTip(this.btnCopyToPlaylists, "Remove from conversion window");
            this.btnCopyToPlaylists.UseVisualStyleBackColor = true;
            this.btnCopyToPlaylists.Click += new System.EventHandler(this.btnCopyToPlaylists_Click);
            // 
            // cbSelectConvert
            // 
            this.cbSelectConvert.AutoSize = true;
            this.cbSelectConvert.Location = new System.Drawing.Point(499, 498);
            this.cbSelectConvert.Name = "cbSelectConvert";
            this.cbSelectConvert.Size = new System.Drawing.Size(69, 17);
            this.cbSelectConvert.TabIndex = 17;
            this.cbSelectConvert.Text = "Select all";
            this.cbSelectConvert.UseVisualStyleBackColor = true;
            this.cbSelectConvert.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(833, 526);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(108, 23);
            this.btnConvert.TabIndex = 18;
            this.btnConvert.Text = "Convert Playlist(s)";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // progressConvert
            // 
            this.progressConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressConvert.Location = new System.Drawing.Point(499, 566);
            this.progressConvert.Name = "progressConvert";
            this.progressConvert.Size = new System.Drawing.Size(442, 24);
            this.progressConvert.Step = 1;
            this.progressConvert.TabIndex = 19;
            this.progressConvert.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // xmlFilePathDlg
            // 
            this.xmlFilePathDlg.FileName = "openFileDialog1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logitech Media Server Playlist Generator";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToITunesXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFolderForLogitchMediaServerPlaylistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbDlg;
        private System.Windows.Forms.ListBox lbPlayLists;
        private System.Windows.Forms.CheckBox cbSelectiTunes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtItunesPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPlaylists;
        private System.Windows.Forms.ListBox lbConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyToConvert;
        private System.Windows.Forms.Button btnCopyToPlaylists;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backworker;
        private System.Windows.Forms.CheckBox cbSelectConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ProgressBar progressConvert;
        private System.Windows.Forms.OpenFileDialog xmlFilePathDlg;
    }
}

