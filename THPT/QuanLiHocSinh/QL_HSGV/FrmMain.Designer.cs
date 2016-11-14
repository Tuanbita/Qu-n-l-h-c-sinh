namespace QL_HSGV
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TStrip_HS = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_GV = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_TTGD = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_QLND = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TStrip_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStrip_HS,
            this.TStrip_GV,
            this.TStrip_TTGD,
            this.TStrip_QLND,
            this.TStrip_Help,
            this.TStrip_Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TStrip_HS
            // 
            this.TStrip_HS.Name = "TStrip_HS";
            this.TStrip_HS.Size = new System.Drawing.Size(67, 20);
            this.TStrip_HS.Text = "Học Sinh";
            this.TStrip_HS.Click += new System.EventHandler(this.TStrip_HS_Click);
            // 
            // TStrip_GV
            // 
            this.TStrip_GV.Name = "TStrip_GV";
            this.TStrip_GV.Size = new System.Drawing.Size(68, 20);
            this.TStrip_GV.Text = "Giáo viên";
            this.TStrip_GV.Click += new System.EventHandler(this.TStrip_GV_Click);
            // 
            // TStrip_TTGD
            // 
            this.TStrip_TTGD.Name = "TStrip_TTGD";
            this.TStrip_TTGD.Size = new System.Drawing.Size(126, 20);
            this.TStrip_TTGD.Text = "Thông tin giảng dạy";
            this.TStrip_TTGD.Click += new System.EventHandler(this.TStrip_TTGD_Click);
            // 
            // TStrip_QLND
            // 
            this.TStrip_QLND.Name = "TStrip_QLND";
            this.TStrip_QLND.Size = new System.Drawing.Size(125, 20);
            this.TStrip_QLND.Text = "Quản lý người dùng";
            this.TStrip_QLND.Click += new System.EventHandler(this.TStrip_QLND_Click);
            // 
            // TStrip_Help
            // 
            this.TStrip_Help.Name = "TStrip_Help";
            this.TStrip_Help.Size = new System.Drawing.Size(44, 20);
            this.TStrip_Help.Text = "Help";
            // 
            // TStrip_Thoat
            // 
            this.TStrip_Thoat.Name = "TStrip_Thoat";
            this.TStrip_Thoat.Size = new System.Drawing.Size(50, 20);
            this.TStrip_Thoat.Text = "Thoát";
            this.TStrip_Thoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 420);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QL_HSGV.Properties.Resources.a8f8218643e95c0bd238a1fa398db6b6;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 420);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(665, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý Giáo viên - Học sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TStrip_TTGD;
        private System.Windows.Forms.ToolStripMenuItem TStrip_HS;
        private System.Windows.Forms.ToolStripMenuItem TStrip_GV;
        private System.Windows.Forms.ToolStripMenuItem TStrip_QLND;
        private System.Windows.Forms.ToolStripMenuItem TStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem TStrip_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

