using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataGridView
{
    public partial class AdminMenuPanel : Form
    {
        public AdminMenuPanel()
        {
            InitializeComponent();
        }

        private void ButtonUserManagmentPanel_Click(object sender, EventArgs e)
        {
            UserManagementPanel form1 = new UserManagementPanel();
            form1.Show();
            this.Hide();//jeżeli będzie logowanie zmienić Close() zamyka, Hide() ukrywa
        }

        private void ButtonManagementPackagePanel_Click(object sender, EventArgs e)
        {
            PackageManagementPanel form2 = new PackageManagementPanel();
            form2.Show();
            this.Hide();
        }

        private void AdminMenuPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
