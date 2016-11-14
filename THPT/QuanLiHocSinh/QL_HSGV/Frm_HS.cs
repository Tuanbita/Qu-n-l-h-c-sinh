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
    public partial class Frm_HS : Form
    {
        public static string Uutien;
        private bool _dangtimma = false;
        private bool _dangtimten = false;
        private bool _dangtimlop = false;
        ConnectDB CN = new ConnectDB();
        public Frm_HS()
        {
            InitializeComponent();
            if(Uutien == "1")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLammoi.Enabled = true;
            }
            else btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void Frm_HS_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = CN.Get("Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop");
        }

        private void DTGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvHocSinh.CurrentRow.Selected = true; //dữ liệu đc chọn cả dòng
            }
            catch
            { }
        }
        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            _dangtimma = true;
            string _sql = "";
            if (_dangtimma == true)
            {
                _sql = @"Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop and mahs like '%" + txtTimMa.Text + "%'";
                if (_dangtimten)
                {
                    _sql += " and hovaten like N'%" + txtTimTen.Text + "%'";
                }
                if (_dangtimlop)
                {
                    _sql += " and tenlop = N'" + txtTimLop.Text + "'";
                }

                dgvHocSinh.DataSource = CN.Get(_sql);
            }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
              _dangtimten = true;
            string _sql = "";
            if (_dangtimten == true)
            {
                _sql = @"Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop and hovaten like N'%" + txtTimTen.Text + "%'";
                if (_dangtimma)
                {
                    _sql += " and mahs like N'%" + txtTimMa.Text + "%'";
                }
                if (_dangtimlop)
                {
                    _sql += " and tenlop = N'" + txtTimLop.Text + "'";
                }
                dgvHocSinh.DataSource = CN.Get(_sql);
            }
        }

        private void txtTimLop_TextChanged(object sender, EventArgs e)
        {
            _dangtimlop = true;
            string _sql = "";
            if (_dangtimlop == true)
            {
                _sql = @"Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop and tenlop like N'%" + txtTimLop.Text + "%'";
                if (_dangtimma)
                {
                    _sql += " and mahs like N'%" + txtTimMa.Text + "%'";
                }
                if (_dangtimten)
                {
                    _sql += " and hovaten like N'%" + txtTimTen.Text + "%'";
                }
                dgvHocSinh.DataSource = CN.Get(_sql);
            }
        }

        private void txtTimMa_Click(object sender, EventArgs e)
        {
            if (!_dangtimma) txtTimMa.Text = "";
        }

        private void txtTimTen_Click(object sender, EventArgs e)
        {
            if (!_dangtimten) txtTimTen.Text = "";
        }

        private void txtTimLop_Click(object sender, EventArgs e)
        {
            if (!_dangtimlop) txtTimLop.Text = "";
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex>=0 && Uutien=="1")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Frm_ThongTinHS frmTTHS = new Frm_ThongTinHS(dgvHocSinh.CurrentRow.Cells[0].Value.ToString());
                if (Uutien == "1")
                {
                    frmTTHS.kt = -1;
                }
                else frmTTHS.kt = -2;
                frmTTHS.ShowDialog();
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_ThongTinHS frmTTHS = new Frm_ThongTinHS(dgvHocSinh.CurrentRow.Cells[0].Value.ToString());
            frmTTHS.ShowDialog();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = CN.Get("Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlrXoa;
            dlrXoa=MessageBox.Show("Bạn chắc chắn muốn xóa?","Xóa học sinh",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dlrXoa==DialogResult.OK)
            {
                CN.Excecute(@"delete  from tblHocsinh where mahs='" + dgvHocSinh.CurrentRow.Cells[0].Value.ToString() + "'");
                dgvHocSinh.DataSource = CN.Get("Select MaHS,Hovaten,GT,Ngaysinh ,Diachi,quequan,TenLop from tblhocsinh a,tblLop b where a.Malop=b.MaLop");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThongTinHS frmTTHS = new Frm_ThongTinHS(1);
            frmTTHS.ShowDialog();
        }

    }
}
