using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDia
{
    public partial class ChiTietPhieuNhap : Form
    {
        private string _mapn;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public ChiTietPhieuNhap(string mapn) : this()
        {
            _mapn = mapn;
        }
        void loaddata()
        {
            string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaPhieuNhap = N'" + _mapn + "'";
            dataGridView1.DataSource = _ketnoi.Execute(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mabangdia = txtMaBangDia.Text;
            string soluong = txtSoLuong.Text;
            string ghichu = txtNote.Text;
            string gia = txtGia.Text;
            string query = "INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaBangDia, SoLuong, Gia, GhiChu) VALUES (N'" + _mapn + "'  ,N'" + mabangdia + "',N'" + soluong + "',N'" + gia + "',N'" + ghichu + "')";
            _ketnoi.Execute(query);
            loaddata();
            txtGia.Clear();
            txtMaBangDia.Clear();
            txtSoLuong.Clear();
            txtNote.Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NhapKho nhapkho = new NhapKho();
            nhapkho.Show();
            this.Hide();
        }

        private void txtMaBangDia_TextChanged(object sender, EventArgs e)
        {
            string mabangdia = txtMaBangDia.Text;
            string query = "SELECT * FROM BangDia WHERE MaBangDia = N'" + mabangdia + "'";


            string connectionString = _ketnoi.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        txtTenBangDia.Text = reader["TenBangDia"].ToString();
                        txtGia.Text = reader["GiaThue"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mabangdia = txtMaBangDia.Text;
                string query = "DELETE FROM ChiTietPhieuNhap WHERE MaBangDia = N'" + mabangdia + "'";
                _ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Băng Đĩa Thành Công");
                txtGia.Clear();
                txtMaBangDia.Clear();
                txtSoLuong.Clear();
                txtNote.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn băng đĩa để được xóa!");
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {

                return;
            }

            try
            {
                decimal gia = decimal.Parse(txtGia.Text);


                if (int.TryParse(txtSoLuong.Text, out int soluong))
                {
                    decimal ketqua = soluong * gia;



                }
                else
                {


                    MessageBox.Show("Vui lòng nhập đúng định dạng số.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mabangdia = txtMaBangDia.Text;
            string soluong = txtSoLuong.Text;
            string ghichu = txtNote.Text;
            string gia = txtGia.Text;


            string query = "UPDATE ChiTietPhieuNhap SET SoLuong = N'" + soluong + "', Gia = N'" + gia + "', GhiChu = N'" + ghichu + "'" +
                           "WHERE MaPhieuNhap = N'" + _mapn + "' AND MaBangDia = N'" + mabangdia + "'";

            try
            {

                _ketnoi.ExecuteNonQuery(query);


               

                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            loaddata();
            txtGia.Clear();
            txtMaBangDia.Clear();
            txtSoLuong.Clear();
            txtNote.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMapn.Text =  row.Cells["MaPhieuNhap"].Value.ToString();
                txtMaBangDia.Text = row.Cells["MaBangDia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtNote.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _ketnoi.Execute("SELECT ctpn.*, pn.MaNhaCungCap, pn.NgayNhap, pn.TongGia, pn.MaNhanVien, nv.TenNhanVien, bd.TenBangDia, ncc.TenNhaCungCap " +
                "FROM ChiTietPhieuNhap ctpn JOIN  PhieuNhap pn ON ctpn.MaPhieuNhap = pn.MaPhieuNhap JOIN NhanVien nv ON pn.MaNhanVien = nv.MaNhanVien " +
                "JOIN BangDia bd ON ctpn.MaBangDia = bd.MaBangDia JOIN NhaCungCap ncc ON pn.MaNhaCungCap = ncc.MaNhaCungCap WHERE ctpn.MaPhieuNhap = '" + txtMapn.Text + "'");
            rpPhieuNhap baocao = new rpPhieuNhap();
            baocao.SetDataSource(dt);
            InHDDatHang formbaocao = new InHDDatHang();
            formbaocao.crystalReportViewer1.ReportSource = baocao;
            formbaocao.ShowDialog();
        }

        private void traBangĐiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
