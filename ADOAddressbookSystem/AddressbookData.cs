﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


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

        /// Created Table in addressbook service database
        public void CreateTables()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-DMPB7U8\MSSQLSERVER01; Initial Catalog =AddressbookForADO; Integrated Security = True;");
                Connection.Open();
                SqlCommand command = new SqlCommand("Create table AddressBook(id int identity(1,1)primary key,FirstName varchar(200),LastName varchar(200),Address varchar(200), City varchar(200), State varchar(200), Zip varchar(200), PhoneNumber varchar(50), Email varchar(200)); ", Connection);
                command.ExecuteNonQuery();
                Console.WriteLine("AddressBook table has been  created successfully!");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }

        public const string ConnFile = @"Data Source=DESKTOP-DMPB7U8\MSSQLSERVER01; Initial Catalog =AddressbookForADO; Integrated Security = True;";
        SqlConnection connection = new SqlConnection(ConnFile);
      
        public bool AddContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("SpAddressBook", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@City", model.City);
                    cmd.Parameters.AddWithValue("@State", model.State);
                    cmd.Parameters.AddWithValue("@Zip", model.Zip);
                    cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", model.Email);


                    this.connection.Open();

                    var result = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }



    }
}