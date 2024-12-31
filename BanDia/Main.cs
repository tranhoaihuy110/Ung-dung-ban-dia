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
    public partial class Main : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT MaBangDia,TenBangDia,TheLoai,TinhTrang,NhaSanXuat,GhiChu,GiaThue FROM BangDia ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
}
