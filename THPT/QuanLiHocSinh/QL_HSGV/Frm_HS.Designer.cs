namespace QL_HSGV
{
    partial class Frm_HS
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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.clmMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLớp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimLop = new System.Windows.Forms.TextBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaHS,
            this.clmHoten,
            this.clmNgaySinh,
            this.clmGT,
            this.clmDiaChi,
            this.clmQue,
            this.clmLớp});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 0);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(981, 379);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            this.dgvHocSinh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellDoubleClick);
            this.dgvHocSinh.SelectionChanged += new System.EventHandler(this.DTGV_SelectionChanged);
            // 
            // clmMaHS
            // 
            this.clmMaHS.DataPropertyName = "maHS";
            this.clmMaHS.Frozen = true;
            this.clmMaHS.HeaderText = "Mã Học Sinh";
            this.clmMaHS.Name = "clmMaHS";
            // 
            // clmHoten
            // 
            this.clmHoten.DataPropertyName = "hovaten";
            this.clmHoten.Frozen = true;
            this.clmHoten.HeaderText = "Họ Và Tên";
            this.clmHoten.Name = "clmHoten";
            this.clmHoten.Width = 200;
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "ngaysinh";
            this.clmNgaySinh.HeaderText = "Ngày Sinh";
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.Width = 120;
            // 
            // clmGT
            // 
            this.clmGT.DataPropertyName = "GT";
            this.clmGT.HeaderText = "Giới Tính";
            this.clmGT.Name = "clmGT";
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDiaChi.DataPropertyName = "diachi";
            this.clmDiaChi.HeaderText = "Địa Chỉ";
            this.clmDiaChi.Name = "clmDiaChi";
            // 
            // clmQue
            // 
            this.clmQue.DataPropertyName = "quequan";
            this.clmQue.HeaderText = "Quê Quán";
            this.clmQue.Name = "clmQue";
            this.clmQue.Width = 150;
            // 
            // clmLớp
            // 
            this.clmLớp.DataPropertyName = "tenLop";
            this.clmLớp.HeaderText = "Lớp";
            this.clmLớp.Name = "clmLớp";
            this.clmLớp.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 121);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtTimLop);
            this.groupBox2.Controls.Add(this.txtTimTen);
            this.groupBox2.Controls.Add(this.txtTimMa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txtTimLop
            // 
            this.txtTimLop.Location = new System.Drawing.Point(829, 20);
            this.txtTimLop.Name = "txtTimLop";
            this.txtTimLop.Size = new System.Drawing.Size(149, 20);
            this.txtTimLop.TabIndex = 0;
            this.txtTimLop.Text = "--Lớp";
            this.txtTimLop.Click += new System.EventHandler(this.txtTimLop_Click);
            this.txtTimLop.TextChanged += new System.EventHandler(this.txtTimLop_TextChanged);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(143, 24);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(197, 20);
            this.txtTimTen.TabIndex = 0;
            this.txtTimTen.Text = "   -- Họ tên học sinh";
            this.txtTimTen.Click += new System.EventHandler(this.txtTimTen_Click);
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // txtTimMa
            // 
            this.txtTimMa.Location = new System.Drawing.Point(42, 24);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(97, 20);
            this.txtTimMa.TabIndex = 0;
            this.txtTimMa.Text = "  -- Mã học sinh";
            this.txtTimMa.Click += new System.EventHandler(this.txtTimMa_Click);
            this.txtTimMa.TextChanged += new System.EventHandler(this.txtTimMa_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Image = global::QL_HSGV.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(307, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLammoi.Image = global::QL_HSGV.Properties.Resources.Button_Refresh_icon__1_;
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(191, 20);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(93, 45);
            this.btnLammoi.TabIndex = 0;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Image = global::QL_HSGV.Properties.Resources.edit_icon__1_;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(93, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 45);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Image = global::QL_HSGV.Properties.Resources.Actions_list_add_icon__1_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHocSinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 379);
            this.panel2.TabIndex = 2;
            // 
            // Frm_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_HS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HS";
            this.Load += new System.EventHandler(this.Frm_HS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLớp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimLop;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
    }
}