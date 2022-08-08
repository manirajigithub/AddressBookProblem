using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookProlemUC6
{
    public class MultipleAddressBook
    {
        static PersonAddress addressBookMain = new PersonAddress();
        static Dictionary<string, PersonAddress> addressBooks = new Dictionary<string, PersonAddress>();
        static Dictionary<string, Contact> addressBooks2 = new Dictionary<string, Contact>();
        public void ReadInput()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("ENter Your Choice");
                Console.WriteLine("Press -1 , Add address book");
                Console.WriteLine("Press -2 , Add Contacts");
                Console.WriteLine("Prss -3 ,Display");
                Console.WriteLine("Press-4 , Edit Details");
                Console.WriteLine("Press-5 , remove details");
                Console.WriteLine("Press - 0 , exit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        MultipleAddressBook.AddBook();
                        break;
                    case 2:
                        AddDetails(MultipleAddressBook.BookName(addressBooks), addressBooks2);
                        break;
                    case 3:
                        addressBookMain = MultipleAddressBook.BookName(addressBooks);
                        addressBookMain.ForDisplay();
                        break;
                    case 4:
                        addressBookMain = MultipleAddressBook.BookName(addressBooks);
                        Console.WriteLine("Enter the first name of person");
                        string FirstName = Console.ReadLine();
                        addressBookMain.EditContact();
                        break;
                    case 5:
                        addressBookMain = MultipleAddressBook.BookName(addressBooks);
                        Console.WriteLine("Enter the first Name of person");
                        string FN = Console.ReadLine();
                        addressBookMain.Remove();
                        break;
                    default:
                        Console.WriteLine("Dont want to change anything");
                        break;
                }
            }

        }
        public static void AddBook()
        {
            Console.WriteLine("Enter Addrss Book Name");
            string addBookName = Console.ReadLine();
            addressBooks.Add(addBookName, addressBookMain);
        }
        public void AddMultipleAddressBook()
        {
            Console.WriteLine("How many Address Book,you want to add");
            int cNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < cNumber; i++)
            {
                MultipleAddressBook.AddBook();
            }
            Console.WriteLine("All Address Book Added successfully!\n");
        }
        public void AddDetails(PersonAddress address, Dictionary<string, Contact> newad)
        {
            //Console.WriteLine("Enter First Name");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //string LastName = Console.ReadLine();
            //Console.WriteLine("Enter City");
            //string City = Console.ReadLine();
            //Console.WriteLine("Enter State ");
            //string State = Console.ReadLine();
            //Console.WriteLine("Enter Zip number");
            //double Zip = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter PhoneNumber");
            //double PhoneNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Email");
            //string Email = Console.ReadLine();
            address.AddContact();
        }
        public static PersonAddress BookName(Dictionary<string, PersonAddress> addresss)
        {
            try
            {
                addressBooks = addresss;
                Console.WriteLine("Enter Address Book Name");
                string FirstName = Console.ReadLine();
                PersonAddress address = addressBooks[FirstName];
                Console.WriteLine(address);
                return address;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}