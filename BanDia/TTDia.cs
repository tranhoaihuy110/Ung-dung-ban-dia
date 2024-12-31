using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDia
{
    public partial class TTDia : Form
    {
        private string _madia;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public TTDia()
        {
            InitializeComponent();
        }
        public TTDia(string madia) : this()
        {
            _madia = madia;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = " SELECT * FROM BangDia WHERE MaBangDia = N'" + _madia + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMaBangDia.Text = _madia;
                txtTenBangDia.Text = dt.Rows[0]["TenBangDia"].ToString();
                txtTheLoai.Text = dt.Rows[0]["TheLoai"].ToString();
                txtTinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
                txtHangSX.Text = dt.Rows[0]["NhaSanXuat"].ToString();
                txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
                txtGiaThue.Text = dt.Rows[0]["GiaThue"].ToString();
                txtfilename.Text = dt.Rows[0]["Anh"].ToString();
            }

        }

        private void TTDia_Load(object sender, EventArgs e)
        {
            txtMaBangDia.Enabled = false;
            string query = " SELECT * FROM BangDia WHERE MaBangDia = N'" + _madia + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMaBangDia.Text = _madia;
                txtTenBangDia.Text = dt.Rows[0][1].ToString();
                txtTheLoai.Text = dt.Rows[0][2].ToString();
                txtTinhTrang.Text = dt.Rows[0][3].ToString();
                txtHangSX.Text = dt.Rows[0][4].ToString();
                txtGhiChu.Text = dt.Rows[0][5].ToString();
                txtfilename.Text = dt.Rows[0][6].ToString();
                txtGiaThue.Text = dt.Rows[0][7].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = ofd.FileName;
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnThemanh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string ten = txtTenBangDia.Text;
            string matl = txtTheLoai.Text;
            string mtt = txtTinhTrang.Text;
            string mahang = txtHangSX.Text;
            string ghichu = txtGhiChu.Text;
            string gia = txtGiaThue.Text;
            string imagePath = txtfilename.Text;
            string query = "INSERT INTO BangDia (TenBangDia, TheLoai,TinhTrang,NhaSanXuat,GhiChu,Anh,GiaThue)" + "VALUES(N'" + ten + "',N'" + matl + "',N'" + mtt + "',N'" + mahang + "',N'" + ghichu + "',N'" + imagePath + "',N'" + gia + "')";
            _ketnoi.ExecuteNonQuery(query);
           
            txtGiaThue.Clear();
            txtMaBangDia.Clear();
            txtTenBangDia.Clear();
            txtTheLoai.Clear();
            txtTinhTrang.Clear();
            txtGhiChu.Clear();
            txtHangSX.Clear();
            loaddata();
            this.Hide();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                string ma = txtMaBangDia.Text;
                string ten = txtTenBangDia.Text;
                string matl = txtTheLoai.Text;
                string mtt = txtTinhTrang.Text;
                string mahang = txtHangSX.Text;
                string ghichu = txtGhiChu.Text;
                string gia = txtGiaThue.Text;
            string imagePath = txtfilename.Text;
            string query = "UPDATE BangDia SET " +
                               "TenBangDia = N'" + ten + "', " +
                               "TheLoai = N'" + matl + "', " +
                               "TinhTrang = N'" + mtt + "', " +
                               "NhaSanXuat = N'" + mahang + "', " +
                               "GhiChu = N'" + ghichu + "', " +
                               "Anh = N'" + imagePath + "'," +
                               "GiaThue = N'" + gia + "' " +
                               "WHERE MaBangDia = N'" + ma + "'";

                _ketnoi.ExecuteNonQuery(query);
                loaddata();
                MessageBox.Show("Đã Sửa Băng Đĩa Thành Công");
            loaddata();
            txtGiaThue.Clear();
            txtMaBangDia.Clear();
            txtTenBangDia.Clear();
            txtTheLoai.Clear();
            txtTinhTrang.Clear();
            txtGhiChu.Clear();
            txtHangSX.Clear();
            this.Hide();
            txtfilename.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void txtfilename_TextChanged(object sender, EventArgs e)
        {
            string imagePath = txtfilename.Text;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;

            }
        }
    }
}
