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
    public partial class QLTK : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public QLTK()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuQL menuQL = new MenuQL();
            menuQL.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string matk = txtTenTk.Text;
            string chucvu = comboBoxCV.Text;
            string mk = txtMK.Text;
            string query = "INSERT INTO TaiKhoan (TaiKhoan, MatKhau, ChucVu)" + "VALUES(N'" + matk + "',N'" + mk + "',N'" + chucvu + "')";
            dataGridView1.DataSource = ketnoi.Execute(query);
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matk = txtTenTk.Text;
            string chucvu = comboBoxCV.Text;
            string mk = txtMK.Text;
            string query = "Update TaiKhoan Set ChucVu = N'" + chucvu + "',MatKhau = N'" + mk + "' Where TaiKhoan = N'" + matk + "'";
            dataGridView1.DataSource = ketnoi.Execute(query);
            loaddata();
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT TaiKhoan,ChucVu,TrangThai FROM TaiKhoan";
            dataGridView1.DataSource = ketnoi.Execute(query);
            txtMK.Clear();
            txtTenTk.Clear();
            comboBoxCV.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kíchHoạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string matk = txtTenTk.Text;
            string query = "Update TaiKhoan Set TrangThai = N'Đã kích hoạt' Where TaiKhoan = N'" + matk + "'";
            dataGridView1.DataSource = ketnoi.Execute(query);
            loaddata();
        }

        private void huyKichHoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string matk = txtTenTk.Text;
            string query = "Update TaiKhoan Set TrangThai = N'Chưa kích hoạt' Where TaiKhoan = N'" + matk + "'";
            dataGridView1.DataSource = ketnoi.Execute(query);
            loaddata();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string matk = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM TaiKhoan WHERE TaiKhoan = N'" + matk + "'";
                ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Xóa Tài Khoản Thành Công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để được xóa!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenTk.Text = row.Cells[0].Value.ToString();
          
                comboBoxCV.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
