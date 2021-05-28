using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> NewAddressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact value)
        {
            try
            {
                NewAddressBook.Add(value.Email, value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("That contact already exists");
            }
        }

        // public Contact GetByEmail(string email)
        // {
        //     if (NewAddressBook.ContainsKey(email))
        //     {
        //         return contact;
        //     }
        //     else
        //     {
        //         return ""
        //     }

        // }
        public Contact GetByEmail(string email)
        {
            NewAddressBook.TryGetValue(email, out Contact contact);
            return contact;
        }
    }
}