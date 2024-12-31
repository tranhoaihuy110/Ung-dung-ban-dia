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
    public partial class TimTheoNCC : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public TimTheoNCC()
        {
            InitializeComponent();
        }

        private void TimTheoNCC_Load(object sender, EventArgs e)
        {
            loaddata();
            comboBox1.Items.Clear();
            string queryKH = "SELECT NhaSanXuat FROM BangDia";
            DataTable dt = ketnoi.Execute(queryKH);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT MaBangDia,TenBangDia,TheLoai,TinhTrang,NhaSanXuat,GhiChu,GiaThue FROM BangDia";
            dataGridView1.DataSource = ketnoi.Execute(query);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenncc = comboBox1.Text;
            string query = "Select TenBangDia, TheLoai,TinhTrang,NhaSanXuat,GhiChu,GiaThue From BangDia where NhaSanXuat LIKE N'%" + tenncc + "%'";
            dataGridView1.DataSource = ketnoi.Execute(query);
            if (!string.IsNullOrEmpty(query))
            {
                DataTable result = ketnoi.Execute(query);
                if (result.Rows.Count > 0)
                {
                    dataGridView1.DataSource = result;
                    MessageBox.Show("Tìm thấy dữ liệu.");

                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu.");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn tìm kiếm.");
            }
        }
    }
}
