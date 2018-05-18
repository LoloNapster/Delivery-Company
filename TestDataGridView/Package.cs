using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGridView
{
    public class Package
    {
        public int ID { get; set; }

        public string Status { get; set; }

        public string Date { get; set; }

        public int IDUser { get; set; }

        public string NameUser { get; set; }

        public string SurnameUser { get; set; }

        public string AddressUser { get; set; }

        public Package()
        {
        }

        public Package(int id, string status, string date, int iduser, string nameuser, string surnameuser, string addressuser)
        {
            ID = id;
            Status = status;
            Date = date;
            IDUser = iduser;
            NameUser = nameuser;
            SurnameUser = surnameuser;
            AddressUser = addressuser;
        }
    }
}
