using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADOAddressbookSystem
{
    public class AddressBookData
    {
        public void Create_Database()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-DMPB7U8\MSSQLSERVER01; Initial Catalog =master; Integrated Security = True;");
                Connection.Open();
                SqlCommand command = new SqlCommand("Create database AddressbookForADO;", Connection);
                command.ExecuteNonQuery();
                Console.WriteLine("AddressbookService Database created successfully!");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }


    }
}