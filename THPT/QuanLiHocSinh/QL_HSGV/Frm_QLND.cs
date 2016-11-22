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
    public partial class Frm_QLND : Form
    {
        DataTable dt = new DataTable();
        ConnectDB CN = new ConnectDB();
        public Frm_QLND()
        {
            InitializeComponent();
        }

        private void Frm_QLND_Load(object sender, EventArgs e)
        {
            dong();
            load();
        }

        void load()
        {
            DTGV.DataSource = CN.Get("Select * from tblLogin");
        }

        void dong()
        {
            txt_U.Enabled = txt_P.Enabled = btn_Luu.Enabled = txt_Quyen.Enabled = false;
        }
        void mo()
        {
            btn_Luu.Enabled = true;
            txt_P.Enabled = true;
            txt_U.Enabled = true;
            txt_Quyen.Enabled = true;
        }
        void themTK()
        {
            dong();
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            string s = "insert into tblLogin values('" + txt_U.Text + "', '" + txt_P.Text + "', '" + txt_Quyen.Text + "')";

            if (KT(txt_U.Text) == 0) dt = CN.Get(s);
            else MessageBox.Show("Tài khoản đã tồn tại!!");
            load();
        }

        void SuaTK()
        {
            dong();
            btn_Luu.Enabled = txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            int r = DTGV.CurrentCell.RowIndex;
            string User = DTGV.Rows[r].Cells[0].Value.ToString();
            string s = "update tblLogin set Username = '" + txt_U.Text + "', Pass = '" + txt_P.Text + "', Uutien = '" + txt_Quyen.Text +"' where username = '" + User + "'";
            dt = CN.Get(s);
            load();
        }

        void XoaTK()
        {
            dong();
            int r = DTGV.CurrentCell.RowIndex ;
            string User = DTGV.Rows[r].Cells[0].Value.ToString();
            string s = "delete tblLogin where username = '" + User + "'";
            dt = CN.Get(s);
            load();
        }

        void TK_Q()
        {


            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            string s = "Select * from tblLogin where Uutien like N'%" + txt_Quyen.Text + "%'";
            DTGV.DataSource = CN.Get(s);
        }
        void TK_U()
        {
            dong();
            txt_P.Enabled = txt_U.Enabled = txt_Quyen.Enabled = true;
            string s = "Select * from tblLogin where username like N'%"+txt_U.Text+"%'";
            DTGV.DataSource = CN.Get(s);
        }

        


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            

            if (RdB_Them.Checked == true)
            {
                themTK();
            }
            else
            {
                if (RdB_Sua.Checked == true)
                {
                    SuaTK();
                }
                else
                {
                    XoaTK();
                }
            }
        }

        private void txt_U_TextChanged(object sender, EventArgs e)
        {
            if (RdB_TK.Checked == true) TK_U();
        }

        private void RdB_TK_Click(object sender, EventArgs e)
        {


            btn_Luu.Enabled = false;
            txt_U.Enabled = txt_Quyen.Enabled = true;
            txt_P.ResetText();
            txt_U.ResetText();
            txt_Quyen.ResetText();
        }

        private void txt_P_TextChanged(object sender, EventArgs e)
        {
            if (RdB_TK.Checked == true) TK_U();
        }

        private void RdB_Them_Click(object sender, EventArgs e)
        {
            mo();
        }

        private void RdB_Sua_Click(object sender, EventArgs e)
        {
            mo();
        }

        private void RdB_Xoa_Click(object sender, EventArgs e)
        {
            mo();
        }


        private void DTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_U.Text = DTGV.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txt_P.Text = DTGV.Rows[e.RowIndex].Cells["Pass"].Value.ToString();
            txt_Quyen.Text = DTGV.Rows[e.RowIndex].Cells["Uutien"].Value.ToString();
        }

        private void txt_Quyen_TextChanged(object sender, EventArgs e)
        {
            if (RdB_TK.Checked == true) TK_Q();
        }

        int KT(string s)
        {
            dt = CN.Get("select count (*) from tblLogin where Username = '" + s + "'");
            return Convert.ToInt16(dt.Rows[0][0].ToString());
        }

    }
}
