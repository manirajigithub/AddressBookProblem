using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookProblemUC3;

namespace AddressBookProblemUC3
{
    public class PersonAddress
    {

        public List<Contact> persons = new List<Contact>();

        public void Book()
        {
            persons.Add(new Contact() { FirstName = "Raji", LastName = "Balusupati", City = "Guntur", State = "Andhra Pradesh", Zip = 522003, PhoneNumber = 9542651379, Email = "rajeswaribalusupati907@gmail.com.com", });
            persons.Add(new Contact() { FirstName = "Manikanta", LastName = "Jammula", City = "Guntur", State = "Andhra Pradesh", Zip = 543569, PhoneNumber = 88017263137, Email = "mani678@gmail.com", });
            persons.Add(new Contact() { FirstName = "Manasa ", LastName = "Pasupuleti", City = "Hyderabad", State = "Teleganna", Zip = 522007, PhoneNumber = 8790535678, Email = "manasa123@gmail.com" });
            persons.Add(new Contact() { FirstName = "Vaishu ", LastName = "Narakulapattti", City = "Banglore", State = "Andhra Pradesh", Zip = 534342, PhoneNumber = 9867453612, Email = "vaishu467@gmail.com" });

        }
        public void Show()
        {
            Console.WriteLine("Enter Firstname");
            string? FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string? LastName = Console.ReadLine();
            Console.WriteLine("Enter City");
            string? City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string? State = Console.ReadLine();
            Console.WriteLine("Enter zip Number");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            string? Email = Console.ReadLine();
            persons.Add(new Contact()
            {
                FirstName = FirstName,
                LastName = LastName,
                City = City,
                State = State,
                Zip = Zip,
                PhoneNumber = PhoneNumber,
                Email = Email,
            });
            forDisplay();
        }
        public void Remove()
        {
            Console.WriteLine("total count of List ,it will start with zero: {0} ", persons.Count);   //for reference of user if want to delete then here total count will provide
            Console.WriteLine("Enter index number which contact wants to delete");
            int i = Convert.ToInt32(Console.ReadLine());
            persons.Remove(persons[i]);
            forDisplay();
        }


        public void EditContact()
        {
            //only edit the added contact
            Console.WriteLine("To edit contact list enter First Name");
            string name = Console.ReadLine().ToLower();

            foreach (var Contacts in persons)
            {
                if (persons.Contains(Contacts))
                {
                    if (Contacts.FirstName.Equals(name))
                    {
                        Console.WriteLine("enter the information wants to edit");
                        Console.WriteLine("For edit First Name enter - 0");
                        Console.WriteLine("For edit Last Name enter - 1");
                        Console.WriteLine("For edit City  enter - 2");
                        Console.WriteLine("For edit State  enter - 3");
                        Console.WriteLine("For edit Zip  enter - 4");
                        Console.WriteLine("For edit Phone  enter - 5");
                        Console.WriteLine("For edit Email  enter - 6");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        switch (edit)
                        {
                            case 0:
                                Console.WriteLine("Enter the First Name");
                                Contacts.FirstName = Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Enter the Last Name");
                                Contacts.LastName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter city Name");
                                Contacts.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter State Name");
                                Contacts.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip ");
                                Contacts.Zip = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter Phone Number");
                                Contacts.PhoneNumber = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Email");
                                Contacts.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Contact not exixt");
                                break;
                        }
                    }

                }
            }
            forDisplay();
        }
        public void forDisplay()
        {
            foreach (var Contact in persons)
            {
                Console.WriteLine("Your name is :{0} ", Contact.FirstName + " " + Contact.LastName);
                Console.WriteLine("Your City: {0}", Contact.City);
                Console.WriteLine("Your State: {0}", Contact.State);
                Console.WriteLine("Your Zip:{0}", Contact.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", Contact.PhoneNumber);
                Console.WriteLine("Email: {0}", Contact.Email);
                Console.WriteLine("-------------------------------------");
            }
        }

    }
}