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
    public partial class Login : Form
    {
        ketnoicsdl ketnoi = new ketnoicsdl();
        public Login()
        {
            InitializeComponent();
            btnLogin.Cursor = Cursors.Hand;
                btnThoat.Cursor = Cursors.Hand;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                string taiKhoan = textBoxTaiKhoan.Text;
                string matKhau = textBoxMK.Text;
                if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
                {
                    notifyIcon1.ShowBalloonTip(5000, "Thông báo", "Vui lòng điền tài khoản và mật khẩu", ToolTipIcon.Warning);
                    return;
                }

                string query = "EXEC USP_Form1 @TaiKhoan,@MatKhau";

                DataTable dt = ketnoi.getLogin(query, taiKhoan, matKhau);

              
                if (dt.Rows.Count > 0)
                {

                    string ChucVu = dt.Rows[0]["ChucVu"].ToString();

                    if (ChucVu == "Nhân viên")
                    {
                        Kho.currentUserRole = 1;
                        ThanhToan.currentUserRole = 1;
                        PhieuTra.currentUserRole = 1;
                        QLNCC.currentUserRole = 1;
                       
                        BaoCao.currentUserRole = 1;
                        NhapKho.currentUserRole = 1;
                        ListDia.currentUserRole = 1;
                        ListNCC.currentUserRole = 1;
                        ListTV.currentUserRole = 1;
                        QLTV.currentUserRole = 1;
                        ChoThueDia.currentUserRole = 1;
                        TimDia.currentUserRole = 1;
                        TimNCC.currentUserRole = 1;
                        TimTV.currentUserRole = 1;

                        Menu menuNv = new Menu();
                        menuNv.Show();
                        notifyIcon1.ShowBalloonTip(5000, "Đăng nhập quyền nhân viên", "ĐĂNG NHẬP", ToolTipIcon.Info);

                    }
                    else if (ChucVu == "Quản lý")

                    {
                        Kho.currentUserRole = 2;
                        ThanhToan.currentUserRole = 2;
                        PhieuTra.currentUserRole = 2;
                        QLNCC.currentUserRole = 2;
                        
                        BaoCao.currentUserRole = 2;
                        NhapKho.currentUserRole = 2;
                        ListDia.currentUserRole = 2;
                        ListNCC.currentUserRole = 2;
                        ListTV.currentUserRole = 2;
                        QLTV.currentUserRole = 2;
                        ChoThueDia.currentUserRole = 2;
                        TimDia.currentUserRole = 2;
                        TimNCC.currentUserRole = 2;

                        TimTV.currentUserRole = 2;
                        MenuQL menuql = new MenuQL();
                        menuql.Show();
                        notifyIcon1.ShowBalloonTip(5000, "Đăng nhập quyền quản lý", "ĐĂNG NHẬP", ToolTipIcon.Info);
                    }
                    else if (ChucVu == "Khách hàng")
                    {
                        notifyIcon1.ShowBalloonTip(5000, "Đăng nhập quyền khách hàng", "ĐĂNG NHẬP", ToolTipIcon.Info);
                        MenuKH menuKH = new MenuKH();
                        menuKH.Show();

                    }
                    this.Hide();
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(5000, "Sai tài khoản mật khẩu", "Cảnh báo", ToolTipIcon.Error);
                    textBoxMK.Clear();
                    textBoxTaiKhoan.Clear();
          
                }
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(5000, ex.Message, "Cảnh báo", ToolTipIcon.Error);
                textBoxMK.Clear();
                textBoxTaiKhoan.Clear();
            }
        }

        private void textBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
