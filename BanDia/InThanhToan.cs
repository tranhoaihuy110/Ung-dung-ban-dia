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
    public partial class InThanhToan : Form
    {
        private string _matt;
        ketnoicsdl _ketnoi = new ketnoicsdl();
        public InThanhToan()
        {
            InitializeComponent();
        }
        public InThanhToan(string matt) : this()
        {
            _matt = matt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = " SELECT kh.HoTen AS TenKhachHang, nv.TenNhanVien AS TenNhanVien,ctpt.SoLuong, bd.TenBangDia AS TenBangDia, tt.* FROM ThanhToan tt JOIN PhieuThue pt ON tt.MaPhieuThue = pt.MaPhieuThue JOIN KhachHang kh ON pt.MaKhachHang = kh.MaKhachHang " +
                "JOIN PhieuTra ptra ON tt.MaPhieuTra = ptra.MaPhieuTra JOIN NhanVien nv ON ptra.MaPhieuThue = pt.MaPhieuThue JOIN ChiTietPhieuThue ctpt ON pt.MaPhieuThue = ctpt.MaPhieuThue JOIN BangDia bd ON ctpt.MaBangDia = bd.MaBangDia WHERE MaThanhToan = N'" + _matt + "'";
            DataTable dt = _ketnoi.Execute(query);
            if (dt.Rows.Count > 0)
            {
                txtTenkh.Text = dt.Rows[0][0].ToString();
                txtTennv.Text = dt.Rows[0][1].ToString();
                //txtSoluong.Text = dt.Rows[0][2].ToString();
                //txtTendia.Text = dt.Rows[0][3].ToString();

                txtMaphth.Text =  dt.Rows[0][5].ToString();
                txtMatt.Text = _matt;
                txtMaPhtr.Text = dt.Rows[0][6].ToString();
                txtTienTra.Text = dt.Rows[0][8].ToString();
                txtNgay.Text = dt.Rows[0][7].ToString();
                txtPhitre.Text = dt.Rows[0][9].ToString();
                txtTongtien.Text = dt.Rows[0][10].ToString();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChoThueDia cho = new ChoThueDia();
            cho.Show();
            this.Hide();
        }

        private void InThanhToan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.txtMaPhtr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatt = new System.Windows.Forms.TextBox();
            this.txtMaphth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhitre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaPhtr
            // 
            this.txtMaPhtr.Location = new System.Drawing.Point(224, 330);
            this.txtMaPhtr.Name = "txtMaPhtr";
            this.txtMaPhtr.Size = new System.Drawing.Size(307, 26);
            this.txtMaPhtr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phiếu thuê";
            // 
            // txtTienTra
            // 
            this.txtTienTra.Location = new System.Drawing.Point(224, 443);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(307, 26);
            this.txtTienTra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã phiếu trả";
            // 
            // txtMatt
            // 
            this.txtMatt.Location = new System.Drawing.Point(224, 213);
            this.txtMatt.Name = "txtMatt";
            this.txtMatt.Size = new System.Drawing.Size(307, 26);
            this.txtMatt.TabIndex = 5;
            // 
            // txtMaphth
            // 
            this.txtMaphth.Location = new System.Drawing.Point(224, 271);
            this.txtMaphth.Name = "txtMaphth";
            this.txtMaphth.Size = new System.Drawing.Size(307, 26);
            this.txtMaphth.TabIndex = 7;
            this.txtMaphth.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phí trễ";
            // 
            // txtPhitre
            // 
            this.txtPhitre.Location = new System.Drawing.Point(224, 501);
            this.txtPhitre.Name = "txtPhitre";
            this.txtPhitre.Size = new System.Drawing.Size(307, 26);
            this.txtPhitre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền trả";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(224, 559);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(307, 26);
            this.txtTongtien.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hóa Đơn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(400, 625);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 53);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày trả";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(224, 385);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(307, 26);
            this.txtNgay.TabIndex = 15;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(224, 147);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(307, 26);
            this.txtTennv.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên nhân viên";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(224, 86);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(307, 26);
            this.txtTenkh.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Tên khách hàng";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(174, 625);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(132, 53);
            this.btnIn.TabIndex = 25;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_2);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tiền trả";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // InThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 738);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhitre);
            this.Controls.Add(this.txtMaphth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTienTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhtr);
            this.Name = "InThanhToan";
            this.Text = "InThanhToan";
            this.Load += new System.EventHandler(this.InThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click_2(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _ketnoi.Execute("SELECT kh.HoTen AS TenKhachHang, nv.TenNhanVien AS TenNhanVien,ctpt.SoLuong, bd.TenBangDia AS TenBangDia, tt.* FROM ThanhToan tt JOIN PhieuThue pt ON tt.MaPhieuThue = pt.MaPhieuThue JOIN KhachHang kh ON pt.MaKhachHang = kh.MaKhachHang " +
                "JOIN PhieuTra ptra ON tt.MaPhieuTra = ptra.MaPhieuTra JOIN NhanVien nv ON ptra.MaPhieuThue = pt.MaPhieuThue JOIN ChiTietPhieuThue ctpt ON pt.MaPhieuThue = ctpt.MaPhieuThue JOIN BangDia bd ON ctpt.MaBangDia = bd.MaBangDia WHERE tt.MaThanhToan = '" + txtMatt.Text + "'");
            rpHoadon baocao = new rpHoadon();
            baocao.SetDataSource(dt);
            InTT formbaocao = new InTT();
            formbaocao.crystalReportViewer1.ReportSource = baocao;
            formbaocao.ShowDialog();
        }
    }
}
