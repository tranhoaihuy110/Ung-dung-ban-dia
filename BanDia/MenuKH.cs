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
    public partial class MenuKH : Form
    {
        public MenuKH()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
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

        private void MenuKH_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Main());
            
        }

        private void btnNhieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiaNhieu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainTimtt());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimTheoNCC());
        }

        private void btnThueit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiaIt());
        }
    }
}
