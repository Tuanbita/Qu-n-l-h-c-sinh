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
    public partial class Frm_TTGD : Form
    {
        public Frm_TTGD()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int i = 0;
        ConnectDB con = new ConnectDB();
        void Xoa()
        {
            cmbGV.Text = "";
            cmbLop.Text = "";
            cmbMH.Text = "";
        }
        void KhoaButton()
        {
            cmbGV.Enabled = false;
            cmbLop.Enabled = false;
            cmbMH.Enabled = false;
        }
        void MoButton()
        {
            cmbGV.Enabled = true;
            cmbLop.Enabled = true;
            cmbMH.Enabled = true;
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 1;
            MoButton();
            Xoa();
        }
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 2;
            Xoa();
            cmbGV.Enabled = false;
            cmbMH.Enabled = false;
            cmbLop.Enabled = true;
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 3;
            Xoa();
            MoButton();
        }
        private void Frm_TTGD_Load(object sender, EventArgs e)
        {
            string sql="select * from tblTTGD";
            KhoaButton();
            cmbGV.DataSource = con.Get("select HoTen from tblGiaoVien");
            cmbGV.DisplayMember = "HoTen";
            cmbLop.DataSource = con.Get("select TenLop from tblLop");
            cmbLop.DisplayMember = "TenLop";
            cmbMH.DataSource = con.Get("select TenMon from tblMonHoc");
            cmbMH.DisplayMember = "TenMon";
            Dtgrv_TTGD.DataSource = con.Get(sql);
            Xoa();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            string sql = "select * from tblTTGD";
            if (i == 1)
            {
                Dtgrv_TTGD.DataSource = con.Them(cmbGV.Text,cmbMH.Text,cmbLop.Text);
            }
            if (i == 2)
            {
                Dtgrv_TTGD.DataSource = con.Sua(cmbGV.Text, cmbMH.Text, cmbLop.Text);
            }
            if (i ==3 )
            {
                Dtgrv_TTGD.DataSource = con.Xoa(cmbGV.Text, cmbMH.Text, cmbLop.Text);
                Xoa();
            }
            KhoaButton();
            Dtgrv_TTGD.DataSource = con.Get(sql);
        }

        private void Dtgrv_TTGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = Dtgrv_TTGD.CurrentCell.RowIndex;
            cmbGV.Text = Dtgrv_TTGD.Rows[r].Cells[0].Value.ToString();
            cmbMH.Text = Dtgrv_TTGD.Rows[r].Cells[1].Value.ToString();
            cmbLop.Text = Dtgrv_TTGD.Rows[r].Cells[2].Value.ToString();
        }
    }
}
