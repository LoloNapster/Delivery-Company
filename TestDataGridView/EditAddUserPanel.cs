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
    public partial class EditAddUserPanel : Form
    {
        public User UserInfo { get; set; }

        public EditAddUserPanel()
        {
            InitializeComponent();
            comboBoxFunction.Items.Add("Administrator");
            comboBoxFunction.Items.Add("Kurier");
            comboBoxFunction.Items.Add("Użytkownik");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            UserInfo.ID = int.Parse(textBoxId.Text);
            UserInfo.Name = textBoxName.Text;
            UserInfo.Surname = textBoxSurname.Text;
            UserInfo.Address = textBoxAddress.Text;
            UserInfo.Function = comboBoxFunction.Text;
            UserInfo.Login = textBoxLogin.Text;
            UserInfo.Password = textBoxPassword.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (UserInfo.Name != null  && UserInfo.Surname != null)
            {
                textBoxId.Text = UserInfo.ID.ToString();
                textBoxName.Text = UserInfo.Name.ToString();
                textBoxSurname.Text = UserInfo.Surname.ToString();
                textBoxAddress.Text = UserInfo.Address.ToString();
                comboBoxFunction.SelectedText = UserInfo.Function.ToString();
                textBoxLogin.Text = UserInfo.Login.ToString();
                textBoxPassword.Text = UserInfo.Password.ToString();
            }
            else
            {
                textBoxId.Text = XmlData.FreeIndex().ToString();
            }
        }
    }
}
