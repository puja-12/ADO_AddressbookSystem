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
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)insert data into table");
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
                    addressbook.FirstName = "Pooja";
                    addressbook.LastName = "Rana";
                    addressbook.Address = "Meerut";
                    addressbook.City = "Meerut";
                    addressbook.State = "UP";
                    addressbook.Zip = "234576";
                    addressbook.PhoneNumber = "1234567890";
                    addressbook.Email = "puja@gmail.com";
                    addressBookData.AddContact(addressbook);
                    Console.WriteLine("Record Inserted successfully");
                    break;
                default:
                    Console.WriteLine("Please choose the correct option!");
                    break;
            }
        }
    }
}