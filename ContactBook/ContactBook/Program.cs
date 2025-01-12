namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menuService = new Services.MenuService();
            var contactService = new Services.ContactService();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Contact List\n1: Add Contact \n2: View Contacts \n3: Save Contacts \n4: Exit\nChoose an option: ");

                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        menuService.CreateContactDialog();
                        Console.WriteLine("Contact added successfully.");
                        break;

                    case 2:
                        menuService.ViewAllContactsDialog();
                        break;
                    case 3:
                        contactService.Save();
                        Console.WriteLine("Contacts saved successfully.");
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
