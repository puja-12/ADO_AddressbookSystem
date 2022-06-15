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
            addressBookData.Create_Database();
        }
    }
}