// See https://aka.ms/new-console-template for more information
using AddressBookLinq;

Console.WriteLine("Hello, World!");
AddressBookTable table = new AddressBookTable();
table.AddContacts();
table.Display();
Console.ReadKey();