using ContactBook.Services;
using ContactBook.Models;

namespace ContactBook.Tests
{
    public class ContactService_Test
    {
        [Fact]
        public void CreateContactShouldReturnContact()
        {
            //ARRANGE
            MenuService _contactService = new();
            var contact = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "",
                PhoneNumber = "1234567890",
                Address = "123 Main",
                ZipCode = "12345",
                City = "New York"
            };

            //ACT
            Contact result = _contactService.CreateContactDialog();

            //ASSERT
            Assert.NotNull(result); 
            Assert.Equal(contact.FirstName, result.FirstName);  
            Assert.Equal(contact.LastName, result.LastName);   
            Assert.Equal(contact.Email, result.Email);
            Assert.Equal(contact.PhoneNumber, result.PhoneNumber);
            Assert.Equal(contact.Address, result.Address);
            Assert.Equal(contact.ZipCode, result.ZipCode);
            Assert.Equal(contact.City, result.City); 
        }
    }
}
