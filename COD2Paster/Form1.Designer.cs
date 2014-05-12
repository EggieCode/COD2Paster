namespace COD2Paster
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tctrCOD2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOrderPlist = new System.Windows.Forms.ComboBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.tabPageStats = new System.Windows.Forms.TabPage();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tctrCOD2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.tabPageStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "Load log";
            this.toolStripButton1.Click += new System.EventHandler(this.buttonLoadLog_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton2.Text = "Test";
            this.toolStripButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tctrCOD2
            // 
            this.tctrCOD2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctrCOD2.Controls.Add(this.tabPage1);
            this.tctrCOD2.Controls.Add(this.tabPageStats);
            this.tctrCOD2.Location = new System.Drawing.Point(0, 28);
            this.tctrCOD2.Name = "tctrCOD2";
            this.tctrCOD2.SelectedIndex = 0;
            this.tctrCOD2.Size = new System.Drawing.Size(897, 360);
            this.tctrCOD2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbOrderPlist);
            this.tabPage1.Controls.Add(this.dgvPlayers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbOrderPlist
            // 
            this.cbOrderPlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrderPlist.FormattingEnabled = true;
            this.cbOrderPlist.Items.AddRange(new object[] {
            "Team ↓",
            "Team ↑",
            "Playername ↓",
            "Playername ↑",
            "Kills ↓",
            "Kills ↑",
            "Deads ↓",
            "Deads ↑"});
            this.cbOrderPlist.Location = new System.Drawing.Point(657, 3);
            this.cbOrderPlist.Name = "cbOrderPlist";
            this.cbOrderPlist.Size = new System.Drawing.Size(224, 21);
            this.cbOrderPlist.TabIndex = 1;
            this.cbOrderPlist.SelectedIndexChanged += new System.EventHandler(this.cbOrderPlist_SelectedIndexChanged);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToOrderColumns = true;
            this.dgvPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(6, 30);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(875, 298);
            this.dgvPlayers.TabIndex = 0;
            // 
            // tabPageStats
            // 
            this.tabPageStats.Controls.Add(this.cbView);
            this.tabPageStats.Controls.Add(this.dgvStats);
            this.tabPageStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats.Name = "tabPageStats";
            this.tabPageStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStats.Size = new System.Drawing.Size(889, 334);
            this.tabPageStats.TabIndex = 1;
            this.tabPageStats.Text = "Stats";
            this.tabPageStats.UseVisualStyleBackColor = true;
            // 
            // cbView
            // 
            this.cbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbView.FormattingEnabled = true;
            this.cbView.Items.AddRange(new object[] {
            "Rifles",
            "Sniper rifles",
            "Machine guns",
            "Shotguns",
            "Pistols",
            "Grenades"});
            this.cbView.Location = new System.Drawing.Point(685, 6);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(196, 21);
            this.cbView.TabIndex = 1;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbView_SelectedIndexChanged);
            // 
            // dgvStats
            // 
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(6, 33);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.Size = new System.Drawing.Size(875, 295);
            this.dgvStats.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 391);
            this.Controls.Add(this.tctrCOD2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "COD2 Paster - © EggieCode";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tctrCOD2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.tabPageStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tctrCOD2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStats;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.ComboBox cbOrderPlist;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.ComboBox cbView;

    }
}

