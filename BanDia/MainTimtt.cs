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
    public partial class MainTimtt : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public MainTimtt()
        {
            InitializeComponent();
        }

        private void MainTimtt_Load(object sender, EventArgs e)
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
            string tt = comboBox1.Text;
            string query = "Select MaBangDia,TenBangDia,TheLoai,TinhTrang,NhaSanXuat,GhiChu,GiaThue From BangDia where TheLoai LIKE N'%" + tt + "%'";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
