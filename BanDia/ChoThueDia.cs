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
    public partial class ChoThueDia : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        private string makh;

        public ChoThueDia()
        {
            InitializeComponent();
        }

        public ChoThueDia(string makh)
        {
            this.makh = makh;
        }

        private void ChoThueDia_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(makh))
            {
                loaddata();
            }
            else
            {
                loaddata(makh);
                txtMaTV.Text = makh;
            }
        }
        void loaddata()
        {
            string query = "SELECT * FROM PhieuThue";
            dataGridView1.DataSource = ketnoi.Execute(query);
            btnLuu.Enabled = false;
            radioButtonTV.Checked = false;
            radioButtonPT.Checked = false;
            txtPt.Clear();
        }

        void loaddata(string makh)
        {
            string query = $"SELECT * FROM PhieuThue WHERE MaKhachHang = '{makh}'";
            dataGridView1.DataSource = ketnoi.Execute(query);
            btnLuu.Enabled = false;
            radioButtonTV.Checked = false;
            radioButtonPT.Checked = false;
            txtPt.Clear();
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

        private void xemChiTietPhieuThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string mapt = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ChiTietPhieuThue chiTietPhieuThue = new ChiTietPhieuThue(mapt);
            chiTietPhieuThue.Show();
            this.Hide();
        }

        private void cbMa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMa_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try {
                string makh = txtMaTV.Text;
                string ngaythue = DateTime.Now.ToString();
                string query = "INSERT INTO PhieuThue (MaKhachHang, NgayThue,TrangThai) VALUES (N'" + makh + "','" + ngaythue + "', N'Chưa hoàn thành')";
                ketnoi.Execute(query);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void xóaPhiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaTV.Text = row.Cells[1].Value.ToString();
                txtPt.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mapt = txtPt.Text;
            string queryct = "DELETE FROM ChiTietPhieuThue WHERE MaPhieuThue = '"+mapt+"'";
            ketnoi.Execute(queryct);
            string query = "DELETE FROM PhieuThue WHERE MaPhieuThue = '" + mapt + "'";
            ketnoi.Execute(query);
            loaddata();
            txtPt.Clear();
            txtMaTV.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = "";
            if (radioButtonPT.Checked)
            {
                string mapt = txtPt.Text;
                query = $"SELECT * FROM PhieuThue WHERE MaPhieuThue LIKE '%{mapt}%'";
            }
            else if (radioButtonTV.Checked)
            {
                string matv = txtPt.Text;
                query = $"SELECT * FROM PhieuThue WHERE MaKhachHang LIKE '%{matv}%'";
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

        private void traBangĐiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string mapt = txtPt.Text;
                DateTime ngaytra = DateTime.Now;

                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaPhieuThue", mapt },
            { "@NgayTra", ngaytra }
        };

                ketnoicsdl ketnoi = new ketnoicsdl();
                ketnoi.ExecuteStoredProcedure("pc_TraToanBo", parameters);

                MessageBox.Show("Phiếu thuê đã được trả thành công!");
                loaddata();


                PhieuTra phieutt = new PhieuTra();
                phieutt.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            ThanhToan phieuTra = new ThanhToan();
            phieuTra.Show();
            this.Close();
        }
    }
}
