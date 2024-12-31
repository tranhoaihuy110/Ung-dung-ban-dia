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
    public partial class ChiTietPhieuThue : Form
    {
        private string _mapt;
        ketnoicsdl _ketnoi = new ketnoicsdl();

        public ChiTietPhieuThue()
        {
            InitializeComponent();
        }

        public ChiTietPhieuThue(string mapt) : this()
        {
            _mapt = mapt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void ChiTietPhieuThue_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            string query = "SELECT * FROM ChiTietPhieuThue WHERE MaPhieuThue = N'" + _mapt + "'";
            dataGridView1.DataSource = _ketnoi.Execute(query);
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
                        txtHangSX.Text = reader["NhaSanXuat"].ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mabangdia = txtMaBangDia.Text;
                string soluong = txtSoLuong.Text;
                string ngaytra = dateTimePicker1.Text;
                string dongia = txtGia.Text;
                string query = "INSERT INTO ChiTietPhieuThue (MaPhieuThue, MaBangDia, SoLuong, NgayDKTra, TrangThai,DonGia) " +
                    "VALUES(N'" + _mapt + "'  ,N'" + mabangdia + "',N'" + soluong + "',N'" + ngaytra + "', N'Chưa trả',N'"+dongia+"')";
                _ketnoi.Execute(query);
                loaddata();
                txtGia.Clear();
                txtHangSX.Clear();
                
                txtMaBangDia.Clear();
                txtSoLuong.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
      
            string mabangdia = txtMaBangDia.Text;
            string soluong = txtSoLuong.Text;

            string ngaytra = dateTimePicker1.Text;

            
            string query = "UPDATE ChiTietPhieuThue SET SoLuong = N'" + soluong + "', NgayDKTra = N'" + ngaytra + "', TrangThai = N'Chưa trả' " +
                           "WHERE MaPhieuThue = N'" + _mapt + "' AND MaBangDia = N'" + mabangdia + "'";

            try
            {
                
                _ketnoi.ExecuteNonQuery(query);

               
                loaddata();

                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            txtMaBangDia.Clear();
            txtSoLuong.Clear();
           
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    return; 
                }
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaBangDia.Text = row.Cells["MaBangDia"].Value != DBNull.Value ? row.Cells["MaBangDia"].Value.ToString() : string.Empty;
                txtSoLuong.Text = row.Cells["SoLuong"].Value != DBNull.Value ? row.Cells["SoLuong"].Value.ToString() : string.Empty;
             
                if (row.Cells["NgayDKTra"].Value != DBNull.Value)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayDKTra"].Value);
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; 
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mabangdia = txtMaBangDia.Text;
                string query = "DELETE FROM ChiTietPhieuThue WHERE MaBangDia = N'" + mabangdia + "'";
                _ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Băng Đĩa Thành Công");
                txtMaBangDia.Clear();
                txtSoLuong.Clear();
               
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn băng đĩa để được xóa!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChoThueDia choThueDia = new ChoThueDia();
            choThueDia.Show();
            this.Hide();
        }
        
        private void traBangĐiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string mabangdia = txtMaBangDia.Text;
                DateTime ngaytra = DateTime.Now;
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                string dongia = txtGia.Text;
                ketnoicsdl db = new ketnoicsdl();
                

                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaPhieuThue", _mapt },
            { "@MaBangDia", mabangdia },
            { "@NgayTra", ngaytra },
       
            { "@SoLuong", soluong }
        };

                db.ExecuteStoredProcedure("pc_TraRieng", parameters);

                MessageBox.Show("Trả băng đĩa thành công!");

                loaddata();

                PhieuTra phieutt = new  PhieuTra();
                phieutt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            ThanhToan phieuTra = new ThanhToan();
            phieuTra.Show();
            this.Close();
        }
    }
}
