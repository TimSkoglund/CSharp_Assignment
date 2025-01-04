using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Console.Main.App
{
    internal class telefonbok
    {
        private List<Contact> _contacts { get; set; }
        private void DisplayContactDetails(Contact contact)
        {
        Console.WriteLine($"Contact: {contact.förNamn}, {contact.efterNamn},{contact.Email},{contact.Telefon},{contact.Address},{contact.Stad}");
        }
        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
            
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.firstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllCotact()
            {
                DisplayContactDetails(_contacts);
            }
        
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.förNamn.Contains(searchPhrase) || c.efterNamn.Contains(searchPhrase)).ToList();
            DisplayContactDetails(matchingContacts;
        }
    }
}
