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
    public partial class Kho : Form
    {
        public static int currentUserRole;
        ketnoicsdl ketnoi = new ketnoicsdl();
        public Kho()
        {
            InitializeComponent();
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

        private void Kho_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM Kho ";
            dataGridView1.DataSource = ketnoi.Execute(query);
            radioButtonTen.Checked = false;
            radioButtonMa.Checked = false;
            comboBoxTim.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";

            if (radioButtonMa.Checked)
            {
                string id = txtTim.Text;
                query = $"SELECT * FROM Kho WHERE MaBangDia LIKE '%{id}%'";
            }
            else if (radioButtonTen.Checked)
            {
                string name = txtTim.Text;
                query = "SELECT * FROM Kho WHERE TenBangDia LIKE N'%" + name + "%'";
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
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn tìm kiếm.");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Số lượng tăng dần")
            {
                string query = "SELECT * FROM Kho ORDER BY SoLuong ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Số lượng giảm dần")
            {
                string query = "SELECT * FROM Kho ORDER BY SoLuong DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
