﻿using System;
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
    public partial class ListTV : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public static int currentUserRole;
        public ListTV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string matv = dataGridView1.Rows[index].Cells[0].Value.ToString();
            TTthanhVien tthanhVien = new TTthanhVien(matv);
            tthanhVien.Show();
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

        private void ListTV_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ A-Z")
            {
                string query = "SELECT * FROM KhachHang ORDER BY HoTen ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê từ Z-A")
            {
                string query = "SELECT * FROM KhachHang ORDER BY HoTen DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
             else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tuổi thành viên tăng dần")
            {
                string query = "SELECT *, DATEDIFF(YEAR, NgaySinh, GETDATE()) - CASE " +
                    "WHEN DATEADD(YEAR, DATEDIFF(YEAR, NgaySinh, GETDATE()), NgaySinh) > GETDATE() THEN 1 ELSE 0 END AS Tuoi FROM KhachHang ORDER BY Tuoi ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tuổi thành viên giảm dần")
            {
                string query = "SELECT *, DATEDIFF(YEAR, NgaySinh, GETDATE()) - CASE " +
                    "WHEN DATEADD(YEAR, DATEDIFF(YEAR, NgaySinh, GETDATE()), NgaySinh) > GETDATE() THEN 1 ELSE 0 END AS Tuoi FROM KhachHang ORDER BY Tuoi DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tháng thẻ thành viên tăng dần")
            {
                string query = "SELECT *, DATEDIFF(MONTH, NgayDangKy, NgayHetHan) - CASE " +
                "WHEN DATEADD(MONTH, DATEDIFF(MONTH, NgayDangKy, NgayHetHan), NgayDangKy) > NgayHetHan THEN 1 ELSE 0 END AS ThangSuDung " +
                "FROM KhachHang ORDER BY ThangSuDung ASC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }
            else if (comboBoxTim.SelectedItem.ToString() == "Liệt kê theo tháng thẻ thành viên giảm dần")
            {
                string query = "SELECT *, DATEDIFF(MONTH, NgayDangKy, NgayHetHan) - CASE " +
                "WHEN DATEADD(MONTH, DATEDIFF(MONTH, NgayDangKy, NgayHetHan), NgayDangKy) > NgayHetHan THEN 1 ELSE 0 END AS ThangSuDung " +
                "FROM KhachHang ORDER BY ThangSuDung DESC";
                dataGridView1.DataSource = ketnoi.Execute(query);
            }

        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT * FROM KhachHang ";
            dataGridView1.DataSource = ketnoi.Execute(query);
        }
    }
}
