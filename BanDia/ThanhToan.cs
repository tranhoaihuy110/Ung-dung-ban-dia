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
    public partial class ThanhToan : Form
    {
        public static int currentUserRole;
        ketnoicsdl ketnoi = new ketnoicsdl();
        private int maThanhToan;

        // Constructor to accept MaThanhToan
        public ThanhToan(int maThanhToan)
        {
            InitializeComponent();
            this.maThanhToan = maThanhToan;
        }

        public ThanhToan()
        {
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = $"SELECT kh.HoTen AS TenKhachHang, nv.TenNhanVien AS TenNhanVien, tt.* FROM ThanhToan tt JOIN PhieuThue pt ON tt.MaPhieuThue = pt.MaPhieuThue JOIN KhachHang kh ON pt.MaKhachHang = kh.MaKhachHang " +
                $"JOIN PhieuTra ptra ON tt.MaPhieuTra = ptra.MaPhieuTra JOIN NhanVien nv ON ptra.MaPhieuThue = pt.MaPhieuThue JOIN ChiTietPhieuThue ctpt ON pt.MaPhieuThue = ctpt.MaPhieuThue JOIN BangDia bd ON ctpt.MaBangDia = bd.MaBangDia " +
                $"WHERE tt.MaThanhToan = {maThanhToan};";
            dataGridView1.DataSource = ketnoi.Execute(query);
            radioButtonmapt.Checked = false;
            radioButtonMatt.Checked = false;
            radioButtonmaptr.Checked = false;
            comboBoxTim.Text = "";
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";

            if (radioButtonMatt.Checked)
            {
                string matt = txtTim.Text;
                query = $"SELECT * FROM ThanhToan WHERE MaThanhToan LIKE '%{matt}%'";
            }
            else if (radioButtonmapt.Checked)
            {
                string mapt = txtTim.Text;
                query = $"SELECT * FROM ThanhToan WHERE MaThanhToan LIKE '%{mapt}%'";
            }
            else if (radioButtonmaptr.Checked)
            {
                string matr = txtTim.Text;
                query = $"SELECT * FROM ThanhToan WHERE MaThanhToan LIKE '%{matr}%'";
            }

            if (!string.IsNullOrEmpty(query))
            {
                DataTable result = ketnoi.Execute(query);
                if (result.Rows.Count > 0)
                {
                    dataGridView1.DataSource = result;
                    MessageBox.Show("Tìm thấy dữ liệu.");
                    txtTim.Clear();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu.");
                    txtTim.Clear();
                }
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn tìm kiếm.");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Tổng tiền trả tăng dần")
            {
                string query = "SELECT * FROM ThanhToan ORDER BY TongTienTra ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Tổng tiền trả giảm dần")
            {
                string query = "SELECT * FROM ThanhToan ORDER BY TongTienTra DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            if (comboBoxTim.SelectedItem.ToString() == "Phí trễ tăng dần")
            {
                string query = "SELECT * FROM ThanhToan ORDER BY PhiTre ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Phí trễ giảm dần ")
            {
                string query = "SELECT *  FROM ThanhToan ORDER BY PhiTre DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
        }

        private void inHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string matt = dataGridView1.Rows[index].Cells[4].Value.ToString();
            InThanhToan intt = new InThanhToan(matt);
            intt.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }
    }
}
