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
    public partial class NhapKho : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            loaddata();
            cbMa.Items.Clear();
            cBManv.Items.Clear();
            string query = "Select MaNhanVien From NhanVien";
            string queryKH = "SELECT MaNhaCungCap FROM NhaCungCap";
            DataTable dt = ketnoi.Execute(queryKH);
            DataTable cc = ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbMa.Items.Add(dt.Rows[i][0].ToString());
                    cBManv.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }
        void loaddata()
        {
            string query = "SELECT * FROM PhieuNhap ";
            dataGridView1.DataSource = ketnoi.Execute(query);
            btnLuu.Enabled = false;
            cBManv.Enabled = false;
            radioButtonNV.Checked = false;
            radioButtonPN.Checked = false;
            radioButtonNCC.Checked = false;
            txtPt.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string mancc = cbMa.Text;
                string manv = cBManv.Text;
                string ngaynhap = DateTime.Now.ToString();
                string query = "INSERT INTO PhieuNhap (MaNhaCungCap, NgayNhap, TongGia, MaNhanVien) VALUES (N'" + mancc + "','" + ngaynhap + "', 0 , N'" + manv + "')";
                ketnoi.Execute(query);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void cbMa_TextChanged(object sender, EventArgs e)
        {
            cBManv.Enabled = true;
        }

        private void cBManv_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";
            if (radioButtonPN.Checked)
            {
                string mapn = txtPt.Text;
                query = $"SELECT * FROM PhieuNhap WHERE MaPhieuNhap LIKE '%{mapn}%'";
            }
            else if (radioButtonNV.Checked)
            {
                string manv = txtPt.Text;
                query = $"SELECT * FROM PhieuNhap WHERE MaNhanVien LIKE '%{manv}%'";
            }
            else if (radioButtonNCC.Checked)
            {
                string mancc = txtPt.Text;
                query = $"SELECT * FROM PhieuNhap WHERE MaNhaCungCap LIKE '%{mancc}%'";
            }

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mapn = txtPt.Text;
            string queryct = "DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap = '" + mapn + "'";
            ketnoi.Execute(queryct);
            string query = "DELETE FROM PhieuNhap WHERE MaPhieuNhap = '" + mapn + "'";
            ketnoi.Execute(query);
            loaddata();
            txtPt.Clear();
            cbMa.Text = "";
            cBManv.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbMa.Text = row.Cells[1].Value.ToString();
                txtPt.Text = row.Cells[0].Value.ToString();
                cBManv.Text = row.Cells[4].Value.ToString();
            }
        }

        private void xemChiTietPhieuThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string mapn = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap(mapn);
            chiTietPhieuNhap.Show();
            this.Hide();
        }
    }
}
