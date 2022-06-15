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
            Console.WriteLine("Hello, World!");
            AddressBookData addressBookData = new AddressBookData();
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable");
            int op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    addressBookData.Create_Database();
                    break;
                case 2:
                    addressBookData.CreateTables();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option!");
                    break;
            }
        }
    }
}