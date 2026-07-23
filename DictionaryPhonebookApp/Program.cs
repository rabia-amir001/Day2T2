using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryPhonebookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\n===== PHONEBOOK MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search Contact");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. List All Contacts");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine() ??"";

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string addName = Console.ReadLine() ?? ""; 

                        if (phoneBook.ContainsKey(addName))
                        {
                            Console.WriteLine("Contact already exists!");
                        }
                        else
                        {
                            Console.Write("Enter Phone Number: ");
                            string phone = Console.ReadLine() ?? "";

                            phoneBook.Add(addName, phone);
                            Console.WriteLine("Contact added successfully.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Name to Search: ");
                        string searchName = Console.ReadLine() ?? ""; 

                        if (phoneBook.ContainsKey(searchName))
                        {
                            Console.WriteLine($"{searchName} -> {phoneBook[searchName]}");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter Name to Update: ");
                        string updateName = Console.ReadLine() ?? ""; 

                        if (phoneBook.ContainsKey(updateName))
                        {
                            Console.Write("Enter New Phone Number: ");
                            string newPhone = Console.ReadLine() ?? ""; 

                            phoneBook[updateName] = newPhone;
                            Console.WriteLine("Contact updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter Name to Delete: ");
                        string deleteName = Console.ReadLine() ?? "";

                        if (phoneBook.Remove(deleteName))
                        {
                            Console.WriteLine("Contact deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case "5":
                        if (phoneBook.Count == 0)
                        {
                            Console.WriteLine("Phonebook is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Contact List (Sorted) ---");

                            foreach (var contact in phoneBook.OrderBy(c => c.Key))
                            {
                                Console.WriteLine($"{contact.Key} -> {contact.Value}");
                            }
                        }
                        break;

                    case "6":
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}