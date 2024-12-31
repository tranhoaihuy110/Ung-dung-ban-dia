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
    public partial class PhieuTra : Form
    {
        public static int currentUserRole;
        ketnoicsdl ketnoi = new ketnoicsdl();
        public PhieuTra()
        {
            InitializeComponent();
        }

        private void PhieuTra_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM PhieuTra";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string maphieuthue = dataGridView1.SelectedRows[0].Cells["MaPhieuThue"].Value.ToString();
                    string maphieutra = dataGridView1.SelectedRows[0].Cells["MaPhieuTra"].Value.ToString();
                    DateTime ngaytra = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["NgayTra"].Value.ToString());

                    Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaPhieuThue", maphieuthue },
                { "@MaPhieuTra", maphieutra },
                { "@NgayTra", ngaytra }
            };

                    ketnoicsdl ketnoi = new ketnoicsdl();
                    int maThanhToan = ketnoi.ExecuteStoredProcedureWithOutput("pc_ThanhToanVaLayMa", parameters, "@MaThanhToan");

                    MessageBox.Show("Thanh toán thành công!");

                    
                    ThanhToan formThanhToan = new ThanhToan(maThanhToan);
                    formThanhToan.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mptra = txtTim.Text;
            string query = $"SELECT * FROM PhieuTra WHERE MaPhieuTra LIKE '%{mptra}%'";
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
            string mpt = txtList.Text;
            string query = $"SELECT * FROM PhieuTra WHERE MaPhieuThue LIKE '%{mpt}%'";
            if (!string.IsNullOrEmpty(query))
            {
                DataTable result = ketnoi.Execute(query);
                if (result.Rows.Count > 0)
                {
                    dataGridView1.DataSource = result;
                    MessageBox.Show("Tìm thấy dữ liệu.");
                    txtList.Clear();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu.");
                    txtList.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn tìm kiếm.");
            }
        }
    }
}
