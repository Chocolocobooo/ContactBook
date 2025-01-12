using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services
{
    public class MenuService
    {
        private readonly ContactService _contactService = new();

        public void CreateContactDialog()
        {
            Console.Clear();

            Contact contact = new();

            Console.WriteLine("Enter first name; ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name; ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter email; ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter phone number; ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter address; ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter zip code; ");
            contact.ZipCode = Console.ReadLine();

            Console.WriteLine("Enter city; ");
            contact.City = Console.ReadLine();

            _contactService.Add(contact);
        }

        public void ViewAllContactsDialog()
        {
            Console.Clear();

            var contacts = _contactService.GetAll();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{"Id:",-15}{contact.Id}");
                Console.WriteLine($"{"Name:",-15}{contact.FirstName} {contact.LastName}");
                Console.WriteLine($"{"Email:",-15}{contact.Email}");
                Console.WriteLine($"{"Phone Number:",-15}{contact.PhoneNumber}");
                Console.WriteLine($"{"Address:",-15}{contact.Address}");
                Console.WriteLine($"{"ZipCode:",-15}{contact.ZipCode}");
                Console.WriteLine($"{"City:",-15}{contact.City}");
                Console.WriteLine("");
            }
        }
    }
}
