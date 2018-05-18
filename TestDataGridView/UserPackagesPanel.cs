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
    public partial class UserPackagesPanel : Form
    {
        private List<Package> listOfUserPackages;

        private DataTable dt;

        private DataView dv;

        public UserPackagesPanel(string login, string password)//List<Package> dupa)//zrobinie listy jako elemnetu startowego już podawana bo i tak jej nie modyfikujemy
        {
            InitializeComponent();

            dt = new DataTable();
            AddColumns();

            listOfUserPackages = new List<Package>();
            listOfUserPackages = XmlData.LoadListOUserfPackages(XmlData.GetUserId(login,password));

            FillDataTable();
            dv = new DataView(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dv;
        }

        private void FillDataTable()
        {
            foreach (var listOfPackages in listOfUserPackages)
            {
                dt.Rows.Add(listOfPackages.ID, listOfPackages.Status, listOfPackages.Date);
            }
        }

        private void AddColumns()
        {
            dt.Columns.Add("Id");//tylko nazwa kolumny bez typu np.  dt.Columns.Add("IdUser", typeof(int));
            dt.Columns.Add("Status");
            dt.Columns.Add("Date");
        }

        private void UserPackagesPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
