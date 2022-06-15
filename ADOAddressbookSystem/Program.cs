// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

namespace ADOAddressbookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
       
            AddressBookData addressBookData = new AddressBookData();
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)insert data into table\n4)update data");
            int op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    addressBookData.Create_Database();
                    break;
                case 2:
                    addressBookData.CreateTables();
                    break;
                case 3:
                    AddressBookModel addressbook = new AddressBookModel();
                    addressbook.FirstName = "Mansi";
                    addressbook.LastName = "Tomar";
                    addressbook.Address = "ABC colony";
                    addressbook.City = "Gurgaon";
                    addressbook.State = "Haryana";
                    addressbook.Zip = "110055";
                    addressbook.PhoneNumber = "8234575645";
                    addressbook.Email = "mansi@gmail.com";
                    addressBookData.AddContact(addressbook);
                    Console.WriteLine("Record Inserted successfully");
                    break;
                case 4:
                    addressBookData.updateEmployeeDetails();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option!");
                    break;
            }
        }

    }
}