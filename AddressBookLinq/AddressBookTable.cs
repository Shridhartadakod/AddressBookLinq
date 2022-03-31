using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
   public class AddressBookTable
    {
        public void AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("Zip");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Email");
        }
    }
}
