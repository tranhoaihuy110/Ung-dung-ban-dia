using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDia
{
    public partial class QLNV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public QLNV()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuQL menuQL = new MenuQL();
            menuQL.Show();
            this.Hide();
        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string manv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTNhanVien tTNhanVien = new TTNhanVien(manv);
            tTNhanVien.Show();
        }

        private void contextMenuStripNV_Opening(object sender, CancelEventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM NhanVien ";
            txtMa.Enabled = false;
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMa.Text = row.Cells[0].Value != DBNull.Value ? row.Cells[0].Value.ToString() : string.Empty;
                txtTen.Text = row.Cells[1].Value != DBNull.Value ? row.Cells[1].Value.ToString() : string.Empty;
                cBChucVu.Text = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : string.Empty;
                txtSDT.Text = row.Cells[5].Value != DBNull.Value ? row.Cells[5].Value.ToString() : string.Empty;
                txtMoTa.Text = row.Cells[6].Value != DBNull.Value ? row.Cells[6].Value.ToString() : string.Empty;

                DateTime dateValue;
                if (row.Cells[5].Value != DBNull.Value && DateTime.TryParse(row.Cells[5].Value.ToString(), out dateValue))
                {
                    dateTimePicker1.Value = dateValue;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                }

                txtDiaChi.Text = row.Cells[7].Value != DBNull.Value ? row.Cells[7].Value.ToString() : string.Empty;
                cBSex.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : string.Empty;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string mota = txtMoTa.Text;
            string chucvu = cBChucVu.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = cBSex.Text;
            string ngaysinh = dateTimePicker1.Text;
            string query = "INSERT INTO NhanVien (TenNhanVien, ChucVu, DienThoai, DiaChi,MoTa, NgaySinh,GioiTinh)" + "VALUES(N'" + ten + "',N'" + chucvu + "',N'" + sdt + "',N'" + diachi + "',N'" + mota + "',N'" + ngaysinh + "',N'" + gioitinh + "')";
            ketnoi.ExecuteNonQuery(query);
            loaddata();
            txtMoTa.Clear();
            txtMa.Clear();
            txtTen.Clear();
            cBChucVu.SelectedIndex = -1;
            txtSDT.Clear();
            txtDiaChi.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cBSex.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = N'" + ma + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Nhân Viên Thành Công");
                txtMa.Clear();
                txtTen.Clear();
                cBChucVu.SelectedIndex = -1;
                txtSDT.Clear();
                txtDiaChi.Clear();
                dateTimePicker1.Value = DateTime.Now;
                txtMoTa.Clear();
                cBSex.SelectedIndex = -1;
            }
            else
            {
                
                MessageBox.Show("Vui lòng chọn nhân viên để được xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string ten = txtTen.Text;
                string chucvu = cBChucVu.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string ngaysinh = dateTimePicker1.Text;
                string mota = txtMoTa.Text;
                string gioitinh = cBSex.Text;
                string query = "UPDATE NhanVien SET TenNhanVien = N'" + ten + "',ChucVu = N'" + chucvu + "', DienThoai = N'" + sdt + "' , DiaChi = N'" + diachi + "',MoTa = N'" + mota + "', NgaySinh = N'" + ngaysinh + "' , GioiTinh = N'" + gioitinh + "' WHERE MaNhanVien = N'" + ma + "'";


                ketnoi.ExecuteNonQuery(query);

                loaddata();
                MessageBox.Show("Đã Cập Nhật Nhân Viên Thành Công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để được cập nhật!");
            }
        }
    }
}
