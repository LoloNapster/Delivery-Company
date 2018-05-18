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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if (XmlData.IsValidLogin(login, password))
            {
                switch(XmlData.WhatAFunction(login, password))
                {
                    case "Użytkownik":
                        UserPackagesPanel frm1 = new UserPackagesPanel(login, password);
                        frm1.Show();
                        break;
                    case "Administrator":
                        AdminMenuPanel frm2 = new AdminMenuPanel();
                        frm2.Show();
                        break;
                    case "Kurier":
                        PackageManagementPanel frm3 = new PackageManagementPanel();
                        frm3.Show();
                        break;

                }
                this.Hide();
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("Błędne dane", "Info");
            }
            
        }
    }
}
