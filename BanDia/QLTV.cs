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
    public partial class QLTV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public QLTV()
        {
            InitializeComponent();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QLTV_Load(object sender, EventArgs e)
        {
            loaddata();
           
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cBSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string matv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTthanhVien tthanhVien = new TTthanhVien(matv);
            tthanhVien.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentUserRole == 1)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else if (currentUserRole == 2)
            {
                MenuQL menuQL = new MenuQL();
                menuQL.Show();
            }
            this.Hide();
        }

        private void checkBoxTV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = "SELECT * From KhachHang ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMa.Text = row.Cells["MaKhachHang"].Value != DBNull.Value ? row.Cells["MaKhachHang"].Value.ToString() : string.Empty;
                txtTen.Text = row.Cells["HoTen"].Value != DBNull.Value ? row.Cells["HoTen"].Value.ToString() : string.Empty;
                cBSex.Text = row.Cells["GioiTinh"].Value != DBNull.Value ? row.Cells["GioiTinh"].Value.ToString() : string.Empty;
                txtSDT.Text = row.Cells["DienThoai"].Value != DBNull.Value ? row.Cells["DienThoai"].Value.ToString() : string.Empty;
                txtCm.Text = row.Cells["CMND"].Value != DBNull.Value ? row.Cells["CMND"].Value.ToString() : string.Empty;
                dateTimePicker1.Value = row.Cells["NgaySinh"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgaySinh"].Value) : DateTime.Now;
                dateTimePickerDK.Value = row.Cells["NgayDangKy"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayDangKy"].Value): DateTime.Now;
                    }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhachHang = txtMa.Text;
                string hoTen = txtTen.Text;
                string gioiTinh = cBSex.Text;
                string dienThoai = txtSDT.Text;
                string cm = txtCm.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                DateTime ngaydk = dateTimePickerDK.Value;
                DateTime ngayHH = dateTimePickerHH.Value;
                string query = "INSERT INTO KhachHang (HoTen, GioiTinh, DienThoai, CMND, NgaySinh,NgayDangKy,NgayHetHan)" + " VALUES (N'" + hoTen + "',N'" + gioiTinh + "',N'" + dienThoai + "',N'" + cm + "',N'" + ngaySinh + "',N'" + ngaydk + "',N'" + ngayHH + "')";

                ketnoi.Execute(query);

                MessageBox.Show("Thêm thành viên thành công!");
                loaddata();
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtCm.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePickerDK.Value = DateTime.Now;
                dateTimePickerHH.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string maKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM KhachHang WHERE MaKhachHang = N'" + maKhachHang + "'";
                ketnoi.ExecuteNonQuery(query);
                
                loaddata();
                MessageBox.Show("Đã Xóa Khách Hàng Thành Công");
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtCm.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePickerDK.Value = DateTime.Now;
                dateTimePickerHH.Value = DateTime.Now;
            }
            else
            {

                MessageBox.Show("Vui lòng chọn khách hàng để được xóa!");
            
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string hoTen = txtTen.Text;
                string gioiTinh = cBSex.Text;
                string dienThoai = txtSDT.Text;
                string cm = txtCm.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                DateTime ngayDK = dateTimePickerDK.Value;
                DateTime ngayHH = dateTimePickerHH.Value;

                string query = "UPDATE KhachHang SET HoTen = N'" + hoTen + "', GioiTinh = N'" + gioiTinh + "', DienThoai = N'" + dienThoai + "', CMND = N'" + cm + "', NgaySinh = N'" + ngaySinh + "',NgayDangKy = N'" + ngayDK + "',NgayHetHan = N'" + ngayHH + "' WHERE MaKhachHang = N'" + maKhachHang + "'";
             
                ketnoi.Execute(query);

                MessageBox.Show("Cập nhật khách hàng thành công!");
                loaddata();
                txtMa.Clear();
                txtTen.Clear();
                cBSex.SelectedIndex = -1;
                txtSDT.Clear();
                txtCm.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePickerDK.Value = DateTime.Now;
                dateTimePickerHH.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn thành viên để được cập nhật!");
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
