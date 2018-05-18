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
    public partial class EditAddPackagePanel : Form
    {
        public Package PackageInfo { get; set; }

        private List<User> listOnlyUser;

        private DataTable dt;

        private DataView dv;

        public EditAddPackagePanel()
        {
            InitializeComponent();
            dt = new DataTable();
            listOnlyUser = new List<User>();
            listOnlyUser = XmlData.LoadListOfUser();
            AddColumns();
            FillDataTable();
            dv = new DataView(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dv;
            comboBoxStatus.Items.Add("W systemie");
            comboBoxStatus.Items.Add("W magazynie");
            comboBoxStatus.Items.Add("W drodze");
            comboBoxStatus.Items.Add("Dostarczono");
        }

        private void EditAddPackagePanel_Load(object sender, EventArgs e)
        {
            if (PackageInfo.Status != null && PackageInfo.Date != null)
            {
                textBoxID.Text = PackageInfo.ID.ToString();
                comboBoxStatus.SelectedText = PackageInfo.Status.ToString();
                textBoxDate.Text = PackageInfo.Date.ToString();
                textBoxIdUser.Text = PackageInfo.IDUser.ToString();
                textBoxNameUser.Text = PackageInfo.NameUser.ToString();
                textBoxSurnameUser.Text = PackageInfo.SurnameUser.ToString();
                textBoxAddressUser.Text = PackageInfo.AddressUser.ToString();
            }
            else
            {
                textBoxID.Text = XmlData.FreeIndexPackage().ToString();
            }

        }

        private void ButtonAddEdit_Click(object sender, EventArgs e)
        {
            PackageInfo.ID = int.Parse(textBoxID.Text);
            PackageInfo.Status = comboBoxStatus.Text;
            PackageInfo.Date = DateTime.Now.ToLongDateString();
            PackageInfo.IDUser = int.Parse(textBoxIdUser.Text);
            PackageInfo.NameUser = textBoxNameUser.Text;
            PackageInfo.SurnameUser = textBoxSurnameUser.Text;
            PackageInfo.AddressUser = textBoxAddressUser.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void AddColumns()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Address");
        }

        private void FillDataTable()
        {
            foreach (var listOfUsers in listOnlyUser)
            {
                dt.Rows.Add(listOfUsers.ID, listOfUsers.Name, listOfUsers.Surname, listOfUsers.Address);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfData = dataGridView1.SelectedRows.Count;
            textBoxIdUser.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            textBoxNameUser.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBoxSurnameUser.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBoxAddressUser.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

        }
    }
}
