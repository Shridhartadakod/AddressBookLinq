// See https://aka.ms/new-console-template for more information
using AddressBookLinq;

Console.WriteLine("Hello, World!");
AddressBookTable table = new AddressBookTable();
//table.AddContacts();
//table.Display();
//table.EditContact("Harish", "FirstName");
table.DeleteContact("Sagar");
table.RetrieveData("Dharwad", "Karnataka");
Console.ReadKey();
