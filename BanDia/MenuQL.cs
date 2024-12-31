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
    public partial class MenuQL : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public MenuQL()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MenuQL_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Main());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNCC qLNCC = new QLNCC();
            qLNCC.Show();
            this.Hide();
        }

        private void TimNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimNCC timNCC = new TimNCC();
            timNCC.Show();
            this.Hide();
        }

        private void listNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListNCC listNCC = new ListNCC();
            listNCC.Show();
            this.Hide();
        }

        private void quanlydiaMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimDia timDia = new TimDia();
            timDia.Show();
            this.Hide();
        }

        private void timdiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listdiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDia listDia = new ListDia();
            listDia.Show();
            this.Hide();
        }

        private void quanLyThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTV qLTV = new QLTV();
            qLTV.Show();
            this.Hide();
        }

        private void timThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimTV timTV = new TimTV();
            timTV.Show();
            this.Hide();
        }

        private void listThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTV listTV = new ListTV();
            listTV.Show();
            this.Hide();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV qLNV = new QLNV();
            qLNV.Show();
            this.Hide();
        }

        private void TimKiemNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimNV timNV = new TimNV();
            timNV.Show();
            this.Hide();
        }

        private void lietKeNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListNV listNV = new ListNV();
            listNV.Show();
            this.Hide();
        }

        private void thueDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TraDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void xuatBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.Show();
            this.Hide();
        }

        private void datHangBangDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho datHang = new NhapKho();
            datHang.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void quanLyThẻThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ThueTraDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoThueDia thueDia = new ChoThueDia();
            thueDia.Show();
            this.Hide();
        }

        private void quảnLýPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTra phieu = new PhieuTra();
            phieu.Show();
            this.Hide();
        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan thanhtoan = new ThanhToan();
            thanhtoan.Show();
            this.Hide();
        }

        private void quanLyKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainTimtt());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimTheoNCC());
        }

        private void btnNhieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiaNhieu());
        }

        private void btnThueit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiaIt());
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTK qLTK = new QLTK();
            qLTK.Show();
            this.Hide();
        }
    }
}
