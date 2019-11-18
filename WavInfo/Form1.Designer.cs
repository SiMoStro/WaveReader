namespace WavInfo
{
    partial class FormMain
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
            this.w_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w_menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.w_gbMain = new System.Windows.Forms.GroupBox();
            this.w_leftChannelInfo = new System.Windows.Forms.PropertyGrid();
            this.w_splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.w_tlpWaves = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.w_toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.w_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.w_cpChannelLeft = new WavInfo.CustomPanel();
            this.w_cpChannelRight = new WavInfo.CustomPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.w_rightChannelInfo = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            this.w_gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_splitContainerMain)).BeginInit();
            this.w_splitContainerMain.Panel1.SuspendLayout();
            this.w_splitContainerMain.Panel2.SuspendLayout();
            this.w_splitContainerMain.SuspendLayout();
            this.w_tlpWaves.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1037, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w_menuOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // w_menuOpen
            // 
            this.w_menuOpen.Name = "w_menuOpen";
            this.w_menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.w_menuOpen.Size = new System.Drawing.Size(182, 26);
            this.w_menuOpen.Text = "Open...";
            this.w_menuOpen.Click += new System.EventHandler(this.w_menuOpen_Click);
            // 
            // w_gbMain
            // 
            this.w_gbMain.Controls.Add(this.tableLayoutPanel1);
            this.w_gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_gbMain.Location = new System.Drawing.Point(0, 0);
            this.w_gbMain.Margin = new System.Windows.Forms.Padding(4);
            this.w_gbMain.Name = "w_gbMain";
            this.w_gbMain.Padding = new System.Windows.Forms.Padding(4);
            this.w_gbMain.Size = new System.Drawing.Size(240, 500);
            this.w_gbMain.TabIndex = 1;
            this.w_gbMain.TabStop = false;
            this.w_gbMain.Text = "Info";
            // 
            // w_leftChannelInfo
            // 
            this.w_leftChannelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.w_leftChannelInfo.Location = new System.Drawing.Point(4, 4);
            this.w_leftChannelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.w_leftChannelInfo.Name = "w_leftChannelInfo";
            this.w_leftChannelInfo.Size = new System.Drawing.Size(224, 230);
            this.w_leftChannelInfo.TabIndex = 2;
            // 
            // w_splitContainerMain
            // 
            this.w_splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.w_splitContainerMain.Location = new System.Drawing.Point(0, 28);
            this.w_splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.w_splitContainerMain.Name = "w_splitContainerMain";
            // 
            // w_splitContainerMain.Panel1
            // 
            this.w_splitContainerMain.Panel1.Controls.Add(this.w_gbMain);
            this.w_splitContainerMain.Panel1MinSize = 240;
            // 
            // w_splitContainerMain.Panel2
            // 
            this.w_splitContainerMain.Panel2.Controls.Add(this.w_tlpWaves);
            this.w_splitContainerMain.Size = new System.Drawing.Size(1037, 500);
            this.w_splitContainerMain.SplitterDistance = 240;
            this.w_splitContainerMain.SplitterWidth = 5;
            this.w_splitContainerMain.TabIndex = 3;
            // 
            // w_tlpWaves
            // 
            this.w_tlpWaves.ColumnCount = 1;
            this.w_tlpWaves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.Controls.Add(this.w_cpChannelRight, 0, 1);
            this.w_tlpWaves.Controls.Add(this.w_cpChannelLeft, 0, 0);
            this.w_tlpWaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_tlpWaves.Location = new System.Drawing.Point(0, 0);
            this.w_tlpWaves.Margin = new System.Windows.Forms.Padding(4);
            this.w_tlpWaves.Name = "w_tlpWaves";
            this.w_tlpWaves.RowCount = 2;
            this.w_tlpWaves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.Size = new System.Drawing.Size(792, 500);
            this.w_tlpWaves.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w_toolStripProgressBar,
            this.w_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1037, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // w_toolStripProgressBar
            // 
            this.w_toolStripProgressBar.Name = "w_toolStripProgressBar";
            this.w_toolStripProgressBar.Size = new System.Drawing.Size(133, 20);
            // 
            // w_toolStripStatusLabel
            // 
            this.w_toolStripStatusLabel.Name = "w_toolStripStatusLabel";
            this.w_toolStripStatusLabel.Size = new System.Drawing.Size(0, 21);
            // 
            // w_cpChannelLeft
            // 
            this.w_cpChannelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.w_cpChannelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_cpChannelLeft.Location = new System.Drawing.Point(1, 1);
            this.w_cpChannelLeft.Margin = new System.Windows.Forms.Padding(1);
            this.w_cpChannelLeft.Name = "w_cpChannelLeft";
            this.w_cpChannelLeft.Size = new System.Drawing.Size(790, 248);
            this.w_cpChannelLeft.TabIndex = 2;
            // 
            // w_cpChannelRight
            // 
            this.w_cpChannelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_cpChannelRight.Location = new System.Drawing.Point(1, 251);
            this.w_cpChannelRight.Margin = new System.Windows.Forms.Padding(1);
            this.w_cpChannelRight.Name = "w_cpChannelRight";
            this.w_cpChannelRight.Size = new System.Drawing.Size(790, 248);
            this.w_cpChannelRight.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.w_rightChannelInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.w_leftChannelInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 477);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // w_rightChannelInfo
            // 
            this.w_rightChannelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.w_rightChannelInfo.Location = new System.Drawing.Point(4, 242);
            this.w_rightChannelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.w_rightChannelInfo.Name = "w_rightChannelInfo";
            this.w_rightChannelInfo.Size = new System.Drawing.Size(224, 231);
            this.w_rightChannelInfo.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.w_splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Wave info";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.w_gbMain.ResumeLayout(false);
            this.w_splitContainerMain.Panel1.ResumeLayout(false);
            this.w_splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.w_splitContainerMain)).EndInit();
            this.w_splitContainerMain.ResumeLayout(false);
            this.w_tlpWaves.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog w_openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem w_menuOpen;
        private System.Windows.Forms.GroupBox w_gbMain;
        private CustomPanel w_cpChannelLeft;
        private System.Windows.Forms.SplitContainer w_splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel w_tlpWaves;
        private CustomPanel w_cpChannelRight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar w_toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel w_toolStripStatusLabel;
        private System.Windows.Forms.PropertyGrid w_leftChannelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid w_rightChannelInfo;
    }
}

