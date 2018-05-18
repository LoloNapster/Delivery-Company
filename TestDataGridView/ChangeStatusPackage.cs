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
    public partial class ChangeStatusPackage : Form
    {
        public Package PackageInfo { get; set; }

        public ChangeStatusPackage()
        {
            InitializeComponent();
            comboBoxStatus.Items.Add("W systemie");
            comboBoxStatus.Items.Add("W magazynie");
            comboBoxStatus.Items.Add("W drodze");
            comboBoxStatus.Items.Add("Dostarczono");
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            PackageInfo.Status = comboBoxStatus.Text;
            PackageInfo.Date = DateTime.Now.ToLongDateString();
        }

        private void ChangeStatusPackage_Load(object sender, EventArgs e)
        {
            if (PackageInfo.Status != null && PackageInfo.Date != null)
            {
                comboBoxStatus.SelectedText = PackageInfo.Status.ToString();
            }
        }
    }
}
