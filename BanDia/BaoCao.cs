using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDia
{

    public partial class BaoCao : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public BaoCao()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void BaoCao_Load(object sender, EventArgs e)
        {

            loaddata();
            cBNguoiBaoCao.Items.Clear();
            string queryKH = "SELECT MaNhanVien FROM NhanVien";
            DataTable dt = ketnoi.Execute(queryKH);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cBNguoiBaoCao.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                cBNguoiBaoCao.Text = row.Cells["MaNhanVien"].Value != DBNull.Value ? row.Cells["MaNhanVien"].Value.ToString() : string.Empty;
                txtTenBaoCao.Text = row.Cells["TenBaoCao"].Value != DBNull.Value ? row.Cells["TenBaoCao"].Value.ToString() : string.Empty;
                txMabc.Text = row.Cells["MaBaoCao"].Value != DBNull.Value ? row.Cells["MaBaoCao"].Value.ToString() : string.Empty;
                txtDoanhThu.Text = row.Cells["DoanhThu"].Value != DBNull.Value ? row.Cells["DoanhThu"].Value.ToString() : string.Empty;
                dateTimePickerNgayLap.Value = row.Cells["NgayBaoCao"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayBaoCao"].Value) : DateTime.Now;
                dateTimePickerStart.Value = row.Cells["NgayBatDau"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayBatDau"].Value) : DateTime.Now;
                dateTimePickerEnd.Value = row.Cells["NgayKetThuc"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["NgayKetThuc"].Value) : DateTime.Now;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (radioButtonDT.Checked)
            { 
                {
                    string tenBaoCao = txtTenBaoCao.Text;
                    string maNhanVien = cBNguoiBaoCao.SelectedItem?.ToString();
                    DateTime ngayBaoCao = dateTimePickerNgayLap.Value;
                    DateTime ngayBatDau = dateTimePickerStart.Value;
                    DateTime ngayKetThuc = dateTimePickerEnd.Value;

                    if (string.IsNullOrEmpty(maNhanVien))
                    {
                        MessageBox.Show("Vui lòng chọn một nhân viên.");
                        return;
                    }

                    var parameters = new Dictionary<string, object>
    {
        { "@MaNhanVien", int.Parse(maNhanVien) },
        { "@TenBaoCao", tenBaoCao },
        { "@NgayBaoCao", ngayBaoCao },
        { "@NgayBatDau", ngayBatDau },
        { "@NgayKetThuc", ngayKetThuc }
    };

                    try
                    {
                        ketnoi.ExecuteStoredProcedure("sp_BCDoanhThu", parameters);
                        MessageBox.Show("Đã lưu báo cáo thành công!");
                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                    }
                }

            }
            else if (radioButtonNN.Checked)
            {
             
                {
                    
                    string maNhanVien = cBNguoiBaoCao.SelectedItem?.ToString();
                    DateTime ngayBatDau = dateTimePickerStart.Value;
                    DateTime ngayKetThuc = dateTimePickerEnd.Value;

                    if (string.IsNullOrEmpty(maNhanVien))
                    {
                        MessageBox.Show("Vui lòng chọn một nhân viên.");
                        return;
                    }
                    var parameters = new Dictionary<string, object>
    {
        { "@MaNV", int.Parse(maNhanVien) },
        { "@NgayBatDau", ngayBatDau },
        { "@NgayKetThuc", ngayKetThuc }
    };
                    try
                    {
                        ketnoi.ExecuteStoredProcedure("sp_BCtheoBDThueNhieuNhat", parameters);
                        MessageBox.Show("Đã lưu báo cáo thành công!");
                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
            else {
        
                {
                   
                    string maNhanVien = cBNguoiBaoCao.SelectedItem?.ToString();
                    DateTime ngayBatDau = dateTimePickerStart.Value;
                    DateTime ngayKetThuc = dateTimePickerEnd.Value;
                    if (string.IsNullOrEmpty(maNhanVien))
                    {
                        MessageBox.Show("Vui lòng chọn một nhân viên.");
                        return;
                    }
                    var parameters = new Dictionary<string, object>
    {
        { "@MaNV", int.Parse(maNhanVien) },
        { "@NgayBatDau", ngayBatDau },
        { "@NgayKetThuc", ngayKetThuc }
    };

                    try
                    {
                        ketnoi.ExecuteStoredProcedure("sp_BCtheoBDThueItNhat", parameters);
                        MessageBox.Show("Đã lưu báo cáo thành công!");
                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
         }   
       
     
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ketnoi.Execute("SELECT bc.*, nv.TenNhanVien FROM BaoCao bc JOIN NhanVien nv ON bc.MaNhanVien = nv.MaNhanVien WHERE bc.MaBaoCao = '" +txMabc.Text+ "'");
            rpBaoCao baocao = new rpBaoCao();
            baocao.SetDataSource(dt);
            formBaocao formbaocao = new formBaocao();
            formbaocao.crystalReportViewer1.ReportSource = baocao;
            formbaocao.ShowDialog();
        }
        void loaddata()
        {
            string query = "SELECT * FROM BaoCao ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
    
}
