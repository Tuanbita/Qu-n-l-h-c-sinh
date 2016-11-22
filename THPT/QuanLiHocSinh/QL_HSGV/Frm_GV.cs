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
using System.Data.Sql;
namespace QL_HSGV
{
    public partial class Frm_GV : Form
    {
        public static string Uutien;

        string strConnectionString = @"Data Source=.;Initial Catalog=TruongTHPT;Integrated Security=True";    
        ConnectDB CN = new ConnectDB();
        SqlDataAdapter daGiaoVien = null;
        DataTable dtGiaoVien = null;
        public string GetValue(string strsql)
        {
            SqlConnection conn = null;
            string temp = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand(strsql, conn);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                temp = sqldr[0].ToString();
            }
            conn.Close();
            return temp;
        }
        public Frm_GV()
        {
            InitializeComponent();
            if (Uutien == "1")
            {
                txt_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_KiemTra.Enabled = btn_Luu.Enabled = btn_QuayLai.Enabled = btn_LamMoi.Enabled = true;
            }
            else txt_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_KiemTra.Enabled = btn_Luu.Enabled = btn_QuayLai.Enabled = btn_LamMoi.Enabled = false;
        }
                
        
        static int choice_save;// ==1: nút Lưu với thêm
        
        static int choice_return;// ==1: mở kết nối
                                // ==2: thoát
        
        private void Frm_GV_Load(object sender, EventArgs e)
        {
            dgv_GiaoVien.DataSource = CN.Get("Select * from tblGiaovien");
        }

        private void dgv_GiaoVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int CurrentIndex = dgv_GiaoVien.CurrentCell.RowIndex;
                dgv_GiaoVien.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                txt_MaGV.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[0].Value.ToString();
                txt_HoTen.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[1].Value.ToString();
                cbo_GioiTinh.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[2].Value.ToString();
                int dd = int.Parse(dgv_GiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0, 2));
                int MM = int.Parse(dgv_GiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(3, 2));
                int yyyy = int.Parse(dgv_GiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(6, 4));
                dtp_NgaySinh.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[3].Value.ToString();
                txt_DiaChi.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[4].Value.ToString();
                txt_Sdt.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[5].Value.ToString();
                //txtGTinh.Text = Convert.ToString(dgv_NhanVien.Rows[CurrentIndex].Cells[4].Value.ToString());
                txt_Luong.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[6].Value.ToString();
                txt_MaMon.Text = dgv_GiaoVien.Rows[CurrentIndex].Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       
        
        private void dgv_GiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (chk_MaGV.Checked == true)
            // goi store procedure tim theo ma( nhap vao text)
            {
                if (CN.Get("select * from tblGiaoVien where MaGV= '" + txt_TimKiem.Text + "' ") != null)
                {
                    // MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    SqlConnection conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    // đây là đổ dữ liệu vào bảng 
                    daGiaoVien = new SqlDataAdapter("select * from tblGiaoVien where MaGV like N'%" + txt_TimKiem.Text + "%'", conn);
                    dtGiaoVien = new DataTable();
                    dtGiaoVien.Clear();
                    daGiaoVien.Fill(dtGiaoVien);
                    dgv_GiaoVien.DataSource = dtGiaoVien;
                    dtGiaoVien.Dispose();
                    conn.Close();
                    dtGiaoVien = null;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (chk_TenGV.Checked == true)
            // goi store procedure tim theo ma( nhap vao text)
            {
                if (CN.Get("select * from tblGiaoVien where HoTen like N'%" + txt_TimKiem.Text + "%'") != null)
                {
                    //MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlConnection conn = new SqlConnection(strConnectionString);
                    conn.Open();

                    // đây là đổ dữ liệu vào bảng 
                    daGiaoVien = new SqlDataAdapter("select * from tblGiaoVien where HoTen=N'" + txt_TimKiem.Text + "'", conn);
                    dtGiaoVien = new DataTable();
                    dtGiaoVien.Clear();
                    daGiaoVien.Fill(dtGiaoVien);
                    dgv_GiaoVien.DataSource = dtGiaoVien;
                    dtGiaoVien.Dispose();
                    conn.Close();
                    dtGiaoVien = null;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvTimkiem.DataSource = null;
                }
            }
        }
        public void MoDieuKhien()
        {
            txt_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_TimKiem.Enabled = true;
            btn_QuayLai.Enabled = true;
            btn_LamMoi.Enabled = true;
        }

        public void KhoaDieuKhien_Luu()
        {
            txt_Them.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_TimKiem.Enabled = false;
            btn_QuayLai.Enabled = true;
            btn_LamMoi.Enabled = false;
        }
        public void themGiaoVien(string MaGV, string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string MaMon)
        {
            string a = "themGiaoVien";
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            CN.MoKN();
            SqlCommand sqlcmd = new SqlCommand(a, conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaGV", MaGV);
            sqlcmd.Parameters.AddWithValue("@HoTen", HoTen);
            sqlcmd.Parameters.AddWithValue("@GT", GT);
            sqlcmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            sqlcmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            sqlcmd.Parameters.AddWithValue("@SDT", int.Parse(SDT));
            sqlcmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            sqlcmd.Parameters.AddWithValue("@MaMon", MaMon);
            sqlcmd.ExecuteNonQuery();
            
            conn.Dispose();     
            conn.Close();
             
        }

        public void xoaGiaoVien(string MaGV)
        {
            string a = "xoaGiaoVien";
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand(a, conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaGV", MaGV);
            sqlcmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
        }
        public void suaGiaoVien(string MaGV, string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string MaMon)
        {
            string a = "suaGiaoVien";
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand(a, conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaGV", MaGV);
            sqlcmd.Parameters.AddWithValue("@HoTen", HoTen);
            sqlcmd.Parameters.AddWithValue("@GT", GT);
            sqlcmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            sqlcmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            sqlcmd.Parameters.AddWithValue("@SDT", int.Parse(SDT));
            sqlcmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            sqlcmd.Parameters.AddWithValue("@MaMon", MaMon);
            sqlcmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
        }

        private void txt_Them_Click(object sender, EventArgs e)
        {
            choice_save =1;
            choice_return =1;

            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            //btn_Quaylai.Enabled = true;
            //btnLammoi.Enabled = false;
            btn_TimKiem.Enabled = false;

            txt_MaGV.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            choice_save = 2;
            choice_return = 1;
            txt_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            KhoaDieuKhien_Luu();
            //while( txtManv.Text == "")
            // {
            //    MessageBox.Show("Bạn hãy nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaGV.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaGV.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập vào giáo viên muốn xóa");
                txt_MaGV.Focus();
            }
            // != null la  co, bang null la khong co
            else
            {
                try
                {
                    xoaGiaoVien(txt_MaGV.Text);
                    MessageBox.Show("bạn đã xóa thành công");  
                
                }
                catch
                {
                    MessageBox.Show("Xoá không thành công!");
                }

            }
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            // đây là đổ dữ liệu vào bảng 
            daGiaoVien = new SqlDataAdapter("select * from tblGiaoVien", conn);
            dtGiaoVien = new DataTable();
            dtGiaoVien.Clear();
            daGiaoVien.Fill(dtGiaoVien);
            dgv_GiaoVien.DataSource = dtGiaoVien;
            dtGiaoVien.Dispose();
            dtGiaoVien = null;
            conn.Close(); 
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (choice_save == 1)
            {
                if (txt_MaGV.Text == "" ||
                    txt_HoTen.Text == "" ||
                    // txtGioitinh.Text == "" ||
                    //txt_DiaChi.Text == "" ||
                    //txtDiachi.Text == "" ||
                    //txtLuong.Text == "" ||
                    //txtMa_NQL.Text == "" ||
                    // txtNgaysinh.Text == "" ||
                    txt_MaMon.Text == "")
                    MessageBox.Show(" bạn hãy điền đủ thông tin");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn chắc chứ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        // goi mot ham them voi nhu tren
                        try
                        {
                            themGiaoVien(txt_MaGV.Text, txt_HoTen.Text, cbo_GioiTinh.Text, dtp_NgaySinh.Value.Date.ToString("dd/MM/yyyy"), txt_DiaChi.Text, txt_Sdt.Text, txt_Luong.Text, txt_MaMon.Text);
                            MessageBox.Show("Bạn đã thêm thành công");
                            // đưa ra được datagrid view
                            SqlConnection conn = new SqlConnection(strConnectionString);
                            conn.Open();
                            // đây là đổ dữ liệu vào bảng 
                            daGiaoVien = new SqlDataAdapter("select * from tblGiaoVien where MaGV= '" + txt_MaGV.Text + "' ", conn);
                            dtGiaoVien = new DataTable();
                            dtGiaoVien.Clear();
                            daGiaoVien.Fill(dtGiaoVien);
                            dgv_GiaoVien.DataSource = dtGiaoVien;
                            dtGiaoVien.Dispose();
                            dtGiaoVien = null;
                            conn.Close();   
                            MoDieuKhien();
                            txt_MaGV.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Bạn thêm bị lỗi rồi!");
                        }
                    }
            }
            // đây là cho nút lưu_sửa
            if (choice_save == 2)
            {
                if (txt_MaGV.Text == "" ||
                    txt_HoTen.Text == "" ||
                    // txtGioitinh.Text == "" ||
                    //txt_DiaChi.Text == "" ||
                    //txtDiachi.Text == "" ||
                    //txtLuong.Text == "" ||
                    //txtMa_NQL.Text == "" ||
                    // txtNgaysinh.Text == "" ||
                    txt_MaMon.Text == "")
                    MessageBox.Show(" bạn hãy điền đủ thông tin");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn sửa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        // gọi đến hàm sửa 
                        try
                        {
                            suaGiaoVien(txt_MaGV.Text, txt_HoTen.Text, cbo_GioiTinh.Text, dtp_NgaySinh.Value.Date.ToString("dd/MM/yyyy"), txt_DiaChi.Text, txt_Sdt.Text, txt_Luong.Text, txt_MaMon.Text);
                            MessageBox.Show("Bạn đã sửa thành công");
                            // đưa ra được datagrid view
                            SqlConnection conn = new SqlConnection(strConnectionString);
                            conn.Open();
                            // đây là đổ dữ liệu vào bảng 
                            daGiaoVien = new SqlDataAdapter("select * from tblGiaoVien where MaGV= '" + txt_MaGV.Text + "' ", conn);

                            dtGiaoVien = new DataTable();
                            dtGiaoVien.Clear();
                            daGiaoVien.Fill(dtGiaoVien);
                            dgv_GiaoVien.DataSource = dtGiaoVien;
                            dtGiaoVien.Dispose();
                            conn.Close();
                            dtGiaoVien = null;
                            MoDieuKhien();
                            txt_MaGV.Enabled = true;
                            choice_return = 2;
                        }
                        catch
                        {
                            MessageBox.Show("Bạn sửa bị lỗi rồi!");
                        }
                    }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            this.txt_MaGV.ResetText();
            this.txt_HoTen.ResetText();
            //this.txtGioitinh.ResetText();
            //this.txtCMND.ResetText();
            //this.txtNgaysinh.ResetText();
            this.txt_DiaChi.ResetText();
            this.txt_Sdt.ResetText();
            this.txt_Luong.ResetText();
            this.txt_MaMon.ResetText();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            if (choice_return == 1)
            {
                MoDieuKhien();
                txt_MaGV.Enabled = true;
            }
            else //if (choice_return == 2)
                this.Close();
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (GetValue(" select MaGV from tblGiaoVien where MaGV = '" + txt_MaGV.Text + "' ") != null && txt_MaGV.Text != null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SqlConnection conn = new SqlConnection(strConnectionString);
                conn.Open();
                // đây là đổ dữ liệu vào bảng 
                daGiaoVien = new SqlDataAdapter(" select MaGV from tblGiaoVien where MaGV = '" + txt_MaGV.Text + "' ", conn);
                dtGiaoVien = new DataTable();
                dtGiaoVien.Clear();
                daGiaoVien.Fill(dtGiaoVien);
                dgv_GiaoVien.DataSource = dtGiaoVien;
                dtGiaoVien.Dispose();
                dtGiaoVien = null;
                conn.Close();
            }

            else if (GetValue(" select MaGV from tblGiaoVien where MaGV = '" + txt_MaGV.Text + "' ") == null && txt_MaGV.Text != null)
            {
                MessageBox.Show("Mã giáo viên có thể dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private object Getvalue(string p)
        {
            throw new NotImplementedException();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
