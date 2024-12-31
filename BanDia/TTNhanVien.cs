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
    public partial class TTNhanVien : Form
    {
        private string _manv;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public TTNhanVien()
        {
            InitializeComponent();
        }
        public TTNhanVien(string manv) : this()
        {
            _manv = manv;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TTNhanVien_Load(object sender, EventArgs e)
        {
            string query = " SELECT * FROM NhanVien WHERE MaNhanVien = N'" + _manv + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtMaNv.Text = _manv;
                txtTenNv.Text = dt.Rows[0][1].ToString();
                txtChucVu.Text = dt.Rows[0][4].ToString();
                txtSex.Text = dt.Rows[0][2].ToString();
                txtSDT.Text = dt.Rows[0][5].ToString();
                txtDiaChi.Text = dt.Rows[0][7].ToString();

                DateTime dateValue;
                if (DateTime.TryParse(dt.Rows[0][6].ToString(), out dateValue))
                {
                    dateTimePicker1.Value = dateValue;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; // or handle the error as needed
                }

                txtMota.Text = dt.Rows[0][6].ToString();
            }

        }
    }
}
