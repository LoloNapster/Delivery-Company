using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace TestDataGridView
{
    public partial class UserManagementPanel : Form
    {
        private List<User> listOfUser;

        private DataTable dt;

        private DataView dv;

        public UserManagementPanel()
        {
            InitializeComponent();
            
            dt = new DataTable();
            AddColumns();

            listOfUser = new List<User>();
            listOfUser = XmlData.ReadToList();
            FillDataTable();
            dv = new DataView(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dv;
        }

        private void AddColumns()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Address");
            dt.Columns.Add("Function");
            dt.Columns.Add("Login");
            dt.Columns.Add("Password");
        }
 
        private void FillDataTable()
        {
            foreach (var listOfUsers in listOfUser)
            {
                dt.Rows.Add(listOfUsers.ID, listOfUsers.Name, listOfUsers.Surname, listOfUsers.Address, listOfUsers.Function, listOfUsers.Login, listOfUsers.Password);
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            using (EditAddUserPanel frm = new EditAddUserPanel() { UserInfo = new User() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    listOfUser.Add(frm.UserInfo);
            }
            SortListOfUser();
            RefreshDataGridView();
        }

        private void ButtonRemoveUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var user = listOfUser.FirstOrDefault(u => u.ID == userId);
            if (user != null)
                listOfUser.Remove(user);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dt.Rows.Clear();
            FillDataTable();
            dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            XmlData.SaveList(listOfUser);
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            User objt = new User
            {
                ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                Name = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                Surname = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                Address = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString(),
                Function = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                Login = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                Password = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString()
            };

            if (objt != null)
            {
                using (EditAddUserPanel frm = new EditAddUserPanel() { UserInfo = objt })
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        int userId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        var user = listOfUser.FirstOrDefault(u => u.ID == userId);
                        listOfUser.Remove(user);
                        listOfUser.Add(frm.UserInfo);
                        SortListOfUser();
                        RefreshDataGridView();
                    }
                }
            }
        }

        private void SortListOfUser()
        {
            listOfUser = listOfUser.OrderBy(p => p.ID).ToList();
        }

        private void UserManagementPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
