using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter2.Linq.QueriesLib
{
    public class TelephoneBook
    {
        private List<string> _contactList;

        public TelephoneBook()
        {
            _contactList = new List<string>();

            _contactList.Add("Lenna Paprocki");
            _contactList.Add("Donette Foller");
            _contactList.Add("Simona Morasca");
            _contactList.Add("Mitsue Tollner");
            _contactList.Add("Leota Dilliard");
            _contactList.Add("Sage Wieser");
            _contactList.Add("Kris Marrier");
            _contactList.Add("Minna Amigon");
            _contactList.Add("Abel Maclead");
            _contactList.Add("Kiley Caldarera");
            _contactList.Add("Graciela Ruta");

        }


        public List<string> GetContacts()
        {
            return _contactList;
        }

        public List<string> GetContactsByLastName(string lastName)
        {
            var contacts = _contactList.Where(c => c.Contains(lastName)).ToList();

            return contacts;
            
        }

        public List<string> GetSortedContacts(bool assending = true)
        {
            var sorted = _contactList.OrderBy(c => c).ToList();

            if (!assending)
            {
            
                sorted = _contactList.OrderByDescending(c => c).ToList();
            }

            return sorted;
        }

    }
}
