using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblemUC7
{
    public class AddressBook
    {
        public AddressBook()
        {

        }
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictionaryName = new Dictionary<string, List<Contact>>();
        
           public List<Contact> persons = new List<Contact>();
        public void Book(Contact con)
        {
            persons.Add(new Contact() { FirstName = "Raji", LastName = "Balusupati", City = "Guntur", State = "Andhra Pradesh", Zip = 522003, PhoneNumber = 9542651379, Email = "rajeswaribalusupati907@gmail.com.com", });
            persons.Add(new Contact() { FirstName = "Manikanta", LastName = "Jammula", City = "Guntur", State = "Andhra Pradesh", Zip = 543569, PhoneNumber = 88017263137, Email = "mani678@gmail.com", });
            persons.Add(new Contact() { FirstName = "Manasa ", LastName = "Pasupuleti", City = "Hyderabad", State = "Teleganna", Zip = 522007, PhoneNumber = 8790535678, Email = "manasa123@gmail.com" });
            persons.Add(new Contact() { FirstName = "Vaishu ", LastName = "Narakulapattti", City = "Banglore", State = "Andhra Pradesh", Zip = 534342, PhoneNumber = 9867453612, Email = "vaishu467@gmail.com" });


        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Update");
                            contact.FirstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the LastName to Update");
                            contact.LastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Address to Update");
                            contact.Address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the City to Update");
                            contact.City = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the State to Update");
                            contact.State = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter the Email to Update");
                            contact.EmailAddress = Console.ReadLine(); break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); break;
                    }
                }
                Display();
            }
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
        public void AddDictionary(string name)
        {
            if (dictionaryName == null)
            {
                dictionaryName.Add(name, addressBook);
            }
            if (NameExists(name) == false)
            {
                dictionaryName.Add(name, addressBook);
            }

        }
        public void EditingDictionary(string name, string contactName)
        {
            foreach (var data in dictionaryName)
            {
                if (dictionaryName.Keys.Equals(name))
                {
                    addressBook = data.Value;
                    EditContactInAddressBook(contactName);
                }
            }
        }
        public void DeleteDictionaryData(string name)
        {
            foreach (var data in dictionaryName)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                    DeletingContactINAddressBook(name);
                }
            }
            dictionaryName.Remove(name);
        }
        public bool NameExists(string name)
        {
            foreach (var data in dictionaryName.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
