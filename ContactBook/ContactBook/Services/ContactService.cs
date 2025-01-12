using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services
{
    public class ContactService
    {
        private List<Contact> _contacts = [];
        private readonly FileService _fileService = new();

        public void Add(Contact contact)
        {
            _contacts.Add(contact);
            _fileService.SaveToFile(_contacts);

        }

        public void Save()
        {
            _fileService.SaveToFile(_contacts);
        }

        public IEnumerable<Contact> GetAll()
        {
            _contacts = _fileService.LoadListFromFile();
            return _contacts;
        }
    }
}
