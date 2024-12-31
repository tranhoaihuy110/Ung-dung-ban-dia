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
    public partial class DiaIt : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public DiaIt()
        {
            InitializeComponent();
        }

        private void DiaIt_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT MaBangDia,TenBangDia,TheLoai,TinhTrang,NhaSanXuat,GhiChu,GiaThue FROM BangDia ";

            dataGridView1.DataSource = ketnoi.Execute(query);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            if (comboBoxMonth.SelectedIndex >= 0)
            {
                int selectedMonth = comboBoxMonth.SelectedIndex + 1;
                int year = DateTime.Now.Year;

                DateTime startDate = new DateTime(year, selectedMonth, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                string query = @"
            SELECT Top 10 bd.MaBangDia, bd.TenBangDia,bd.TheLoai,bd.TinhTrang,bd.NhaSanXuat,bd.GiaThue, COUNT(*) AS SoLanThue 
            FROM ChiTietPhieuThue ct 
            JOIN PhieuThue pt ON ct.MaPhieuThue = pt.MaPhieuThue 
            JOIN BangDia bd ON ct.MaBangDia = bd.MaBangDia 
            WHERE pt.NgayThue BETWEEN @StartDate AND @EndDate 
            GROUP BY bd.MaBangDia, bd.TenBangDia,bd.TheLoai,bd.TinhTrang,bd.NhaSanXuat,bd.GiaThue
            ORDER BY COUNT(*) ASC";


                using (SqlConnection connection = new SqlConnection(ketnoi.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tháng.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
