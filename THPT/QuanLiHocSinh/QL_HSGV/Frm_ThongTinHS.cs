using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QL_HSGV
{
    public partial class Frm_ThongTinHS : Form
    {
        ConnectDB _con = new ConnectDB();
        string maHS;
        public int kt=0;
        public Frm_ThongTinHS()
        {
            InitializeComponent();
        }
        public Frm_ThongTinHS(string masv)
        {
            InitializeComponent();
            maHS = masv;
        }
        public Frm_ThongTinHS(int k)
        {
            InitializeComponent();
            kt = k;
            lbTittle.Text = "Thêm Học Sinh mới";
            btnLuu.Text = "Thêm Mới";
            txtMaHS.Enabled = true;
        }
       
        private void Frm_ThongTinHS_Load(object sender, EventArgs e)
        {
            if (kt <= 0)
            {
                cboLop.DataSource = _con.Get(@"select malop,tenlop from tblLop");
                cboLop.ValueMember = "malop";
                cboLop.DisplayMember = "tenlop";

                DataTable data = _con.Get(@"select *from tblhocsinh a,tblLop b where a.malop=b.malop and mahs='" + maHS + "'");
                txtMaHS.Text = maHS;
                txtHoTen.Text = data.Rows[0]["HovaTen"].ToString();
                cboLop.Text = data.Rows[0]["tenlop"].ToString();
                cboGT.Text = data.Rows[0]["GT"].ToString();
                txtDiaChi.Text = data.Rows[0]["diachi"].ToString();
                txtQueQuan.Text = data.Rows[0]["quequan"].ToString();
                txtPhuHuynh.Text = data.Rows[0]["Phuhuynh"].ToString();
                txtNgaySinh.Text = data.Rows[0]["ngaysinh"].ToString();
                if (kt == -2) btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           if(kt<=0) _con.Sua_TTHS(txtMaHS.Text, txtHoTen.Text, cboGT.Text, txtNgaySinh.Text, txtDiaChi.Text, txtPhuHuynh.Text, cboLop.Text, txtQueQuan.Text);
           else _con.ThemHS(txtMaHS.Text, txtHoTen.Text, cboGT.Text, txtNgaySinh.Text, txtDiaChi.Text, txtPhuHuynh.Text, cboLop.Text, txtQueQuan.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
