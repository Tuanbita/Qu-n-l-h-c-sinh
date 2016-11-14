using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HSGV
{
    public partial class Frm_DangNhap : Form
    {
        ConnectDB CN = new ConnectDB();
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_DN;
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            string s = "select count(*) from tbllogin where username = '" + txtU.Text + "' and Pass = '" + txtP.Text + "'";
            DataTable dt = CN.Get(s);
            s = dt.Rows[0][0].ToString();
            if(txtU.Text==""||txtP.Text=="")
            {
                this.label.Text = "Thông tin đăng nhập sai!";
                txtU.Focus();
            }
            if (s == "1")
            {
                this.Hide();
                s = "select Uutien from tbllogin where username = '" + txtU.Text + "' and Pass = '" + txtP.Text + "'";
                dt = CN.Get(s);
                s = dt.Rows[0][0].ToString();
                FrmMain.Uutien = s;

                FrmMain M = new FrmMain();
                M.Show();
            }
            else
            {
                this.label.Text = "Thông tin đăng nhập sai!";
            }
        }

        private void btn_RF_Click(object sender, EventArgs e)
        {
            txtU.Clear();
            txtP.Clear();
            txtU.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
