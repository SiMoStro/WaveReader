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
            this.w_splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.w_tlpWaves = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.w_toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.w_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.w_cbChannel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.w_propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.w_cpChannelLeft = new WavInfo.CustomPanel();
            this.w_cpChannelRight = new WavInfo.CustomPanel();
            this.menuStrip1.SuspendLayout();
            this.w_gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w_splitContainerMain)).BeginInit();
            this.w_splitContainerMain.Panel1.SuspendLayout();
            this.w_splitContainerMain.Panel2.SuspendLayout();
            this.w_splitContainerMain.SuspendLayout();
            this.w_tlpWaves.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w_menuOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // w_menuOpen
            // 
            this.w_menuOpen.Name = "w_menuOpen";
            this.w_menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.w_menuOpen.Size = new System.Drawing.Size(155, 22);
            this.w_menuOpen.Text = "Open...";
            this.w_menuOpen.Click += new System.EventHandler(this.w_menuOpen_Click);
            // 
            // w_gbMain
            // 
            this.w_gbMain.Controls.Add(this.w_propertyGrid);
            this.w_gbMain.Controls.Add(this.label1);
            this.w_gbMain.Controls.Add(this.w_cbChannel);
            this.w_gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_gbMain.Location = new System.Drawing.Point(0, 0);
            this.w_gbMain.Name = "w_gbMain";
            this.w_gbMain.Size = new System.Drawing.Size(240, 405);
            this.w_gbMain.TabIndex = 1;
            this.w_gbMain.TabStop = false;
            this.w_gbMain.Text = "Info";
            // 
            // w_splitContainerMain
            // 
            this.w_splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.w_splitContainerMain.Location = new System.Drawing.Point(0, 24);
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
            this.w_splitContainerMain.Size = new System.Drawing.Size(627, 405);
            this.w_splitContainerMain.SplitterDistance = 240;
            this.w_splitContainerMain.TabIndex = 3;
            // 
            // w_tlpWaves
            // 
            this.w_tlpWaves.ColumnCount = 1;
            this.w_tlpWaves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.Controls.Add(this.w_cpChannelLeft, 0, 0);
            this.w_tlpWaves.Controls.Add(this.w_cpChannelRight, 0, 1);
            this.w_tlpWaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_tlpWaves.Location = new System.Drawing.Point(0, 0);
            this.w_tlpWaves.Name = "w_tlpWaves";
            this.w_tlpWaves.RowCount = 2;
            this.w_tlpWaves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.w_tlpWaves.Size = new System.Drawing.Size(383, 405);
            this.w_tlpWaves.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w_toolStripProgressBar,
            this.w_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // w_toolStripProgressBar
            // 
            this.w_toolStripProgressBar.Name = "w_toolStripProgressBar";
            this.w_toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // w_toolStripStatusLabel
            // 
            this.w_toolStripStatusLabel.Name = "w_toolStripStatusLabel";
            this.w_toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // w_cbChannel
            // 
            this.w_cbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.w_cbChannel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.w_cbChannel.FormattingEnabled = true;
            this.w_cbChannel.Location = new System.Drawing.Point(62, 15);
            this.w_cbChannel.Name = "w_cbChannel";
            this.w_cbChannel.Size = new System.Drawing.Size(172, 21);
            this.w_cbChannel.TabIndex = 0;
            this.w_cbChannel.SelectedIndexChanged += new System.EventHandler(this.HandleSelectedChannelChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel";
            // 
            // w_propertyGrid
            // 
            this.w_propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.w_propertyGrid.Location = new System.Drawing.Point(6, 42);
            this.w_propertyGrid.Name = "w_propertyGrid";
            this.w_propertyGrid.Size = new System.Drawing.Size(227, 338);
            this.w_propertyGrid.TabIndex = 2;
            // 
            // w_cpChannelLeft
            // 
            this.w_cpChannelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.w_cpChannelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_cpChannelLeft.Location = new System.Drawing.Point(1, 1);
            this.w_cpChannelLeft.Margin = new System.Windows.Forms.Padding(1);
            this.w_cpChannelLeft.Name = "w_cpChannelLeft";
            this.w_cpChannelLeft.Size = new System.Drawing.Size(381, 200);
            this.w_cpChannelLeft.TabIndex = 2;
            // 
            // w_cpChannelRight
            // 
            this.w_cpChannelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w_cpChannelRight.Location = new System.Drawing.Point(1, 203);
            this.w_cpChannelRight.Margin = new System.Windows.Forms.Padding(1);
            this.w_cpChannelRight.Name = "w_cpChannelRight";
            this.w_cpChannelRight.Size = new System.Drawing.Size(381, 201);
            this.w_cpChannelRight.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.w_splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Wave info";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.w_gbMain.ResumeLayout(false);
            this.w_gbMain.PerformLayout();
            this.w_splitContainerMain.Panel1.ResumeLayout(false);
            this.w_splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.w_splitContainerMain)).EndInit();
            this.w_splitContainerMain.ResumeLayout(false);
            this.w_tlpWaves.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox w_cbChannel;
        private System.Windows.Forms.PropertyGrid w_propertyGrid;
    }
}

