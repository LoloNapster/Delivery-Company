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
    public partial class PackageManagementPanel : Form
    {
        private List<Package> listOfPackage;

        private DataTable dt;

        private DataView dv;

        public PackageManagementPanel()
        {
            InitializeComponent();

            dt = new DataTable();
            AddColumns();

            listOfPackage = new List<Package>();
            listOfPackage = XmlData.ReadToListPackage();

            FillDataTable();
            dv = new DataView(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dv;
        }

        private void FillDataTable()
        {
            foreach (var listOfPackages in listOfPackage)
            {
                dt.Rows.Add(listOfPackages.ID, listOfPackages.Status, listOfPackages.Date, listOfPackages.IDUser, listOfPackages.NameUser, listOfPackages.SurnameUser, listOfPackages.AddressUser);
            }
        }

        private void AddColumns()
        {
            dt.Columns.Add("Id");//dt.Columns.Add("IdUser", typeof(int));
            dt.Columns.Add("Status");
            dt.Columns.Add("Date");
            dt.Columns.Add("Id user");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Address");
        }

        private void PackageManagementPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Surname Like '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv;
        }

        private void ButtonRemovePackage_Click(object sender, EventArgs e)
        {
            int packageId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var package = listOfPackage.FirstOrDefault(u => u.ID == packageId);
            if (package != null)
                listOfPackage.Remove(package);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dt.Rows.Clear();
            FillDataTable();
            dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            XmlData.SaveListPackage(listOfPackage);
        }

        private void SortListOfPackage()
        {
            listOfPackage = listOfPackage.OrderBy(p => p.ID).ToList();
        }

        private void ButtonAddPackage_Click(object sender, EventArgs e)
        {
            using (EditAddPackagePanel frm = new EditAddPackagePanel() { PackageInfo = new Package() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    listOfPackage.Add(frm.PackageInfo);
            }
            RefreshDataGridView();
        }

        private void ButtonEditPackage_Click(object sender, EventArgs e)
        {
            Package objt = new Package
            {
                ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                Status = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                Date = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                IDUser = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()),
                NameUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                SurnameUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                AddressUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString()
            };

            if (objt != null)
            {
                using (EditAddPackagePanel frm = new EditAddPackagePanel() { PackageInfo = objt })
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int packageId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        var package = listOfPackage.FirstOrDefault(p => p.ID == packageId);
                        listOfPackage.Remove(package);
                        listOfPackage.Add(frm.PackageInfo);
                        SortListOfPackage();
                        RefreshDataGridView();
                    }
                }
            }
        }

        private void ButtonChangeStatusPackage_Click(object sender, EventArgs e)
        {
            Package objt = new Package
            {
                ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                Status = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                Date = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                IDUser = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()),
                NameUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                SurnameUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                AddressUser = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString()
            };

            if (objt != null)
            {
                using (ChangeStatusPackage frm = new ChangeStatusPackage() { PackageInfo = objt })
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int packageId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        var package = listOfPackage.FirstOrDefault(p => p.ID == packageId);
                        listOfPackage.Remove(package);
                        listOfPackage.Add(frm.PackageInfo);
                        SortListOfPackage();
                        RefreshDataGridView();
                    }
                }
            }
        }
    }
}
