using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AddressBookProblemUC6;

namespace AddressBookProblemUC6
{
    public class AddressBooks
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>(6);
    }


    public class Contact
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string? Email { get; set; }
    }

    public class PersonAddress
    {
        public Dictionary<string, Contact> persons = new Dictionary<string, Contact>();

        public void Book()
        {
            persons.Add(new Contact() { FirstName = "Raji", LastName = "Balusupati", City = "Guntur", State = "Andhra Pradesh", Zip = 522003, PhoneNumber = 9542651379, Email = "rajeswaribalusupati907@gmail.com.com", });
            persons.Add(new Contact() { FirstName = "Manikanta", LastName = "Jammula", City = "Guntur", State = "Andhra Pradesh", Zip = 543569, PhoneNumber = 88017263137, Email = "mani678@gmail.com", });
            persons.Add(new Contact() { FirstName = "Manasa ", LastName = "Pasupuleti", City = "Hyderabad", State = "Teleganna", Zip = 522007, PhoneNumber = 8790535678, Email = "manasa123@gmail.com" });
            persons.Add(new Contact() { FirstName = "Vaishu ", LastName = "Narakulapattti", City = "Banglore", State = "Andhra Pradesh", Zip = 534342, PhoneNumber = 9867453612, Email = "vaishu467@gmail.com" });
            persons.Add(PersonsOneCon.FirstName, PersonsOneCon);
            persons.Add(PersonsTwoCon.FirstName, PersonsTwoCon);
            persons.Add(PersonsThreeCon.FirstName, PersonsThreeCon);
            persons.Add(PersonsFourCon.FirstName, PersonsFourCon);
            // ForDisplay();

        }

        public void AddContact()
        {

            Console.WriteLine("How many contacts wants to add , any case do not willing to add new contact press 0");
            int newCon = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < newCon; i++)
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
                Contact ContactPer = new Contact()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    City = City,
                    State = State,
                    Zip = Zip,
                    PhoneNumber = PhoneNumber,
                    Email = Email,
                };
                persons.Add(ContactPer.FirstName, ContactPer);

            }
            ForDisplay();
        }
        public void Remove()
        {
            Console.WriteLine("Wants to delete any contact if yes //Press-1, else write any number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("total count of List ,it will start with zero: {0} ", persons.Count);   //for reference of user if want to delete then here total count will provide
                    Console.WriteLine("Enter index number which contact wants to delete");
                    string? i = Console.ReadLine();
                    if (persons.ContainsKey(i))
                    {
                        persons.Remove(i);
                    }
                    else
                    {
                        Console.WriteLine("Contact not found");
                    }
                    ForDisplay();
                    break;
                default:
                    Console.WriteLine("Do not want to remove");
                    break;

            }
        }


        public void EditContact()
        {
            Console.WriteLine("If want to edit contact press 0 , else press any keyword ");
            int editCon = Convert.ToInt32(Console.ReadLine());
            switch (editCon)
            {
                case 0:
                    //only edit the added contact
                    Console.WriteLine("To edit contact list enter First Name");
                    string name = Console.ReadLine().ToLower();

                    Contact cust;
                    if (persons.TryGetValue(name, out cust))
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
                                cust.FirstName = Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Enter the Last Name");
                                cust.LastName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter city Name");
                                cust.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter State Name");
                                cust.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip ");
                                cust.Zip = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter Phone Number");
                                cust.PhoneNumber = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Email");
                                cust.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Contact not exixt");
                                break;
                        }
                    }
                    ForDisplay();
                    break;
                default:
                    Console.WriteLine("Do Not want to edit");
                    break;



            }
        }
        public void ForDisplay()
        {
            foreach (KeyValuePair<string, Contact> CustomerContact in persons)
            {
                Contact custContct = CustomerContact.Value;
                Console.WriteLine("Your name is :{0} ", custContct.FirstName + " " + custContct.LastName);
                Console.WriteLine("Your City: {0}", custContct.City);
                Console.WriteLine("Your State: {0}", custContct.State);
                Console.WriteLine("Your Zip:{0}", custContct.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", custContct.PhoneNumber);
                Console.WriteLine("Email: {0}", custContct.Email);
                Console.WriteLine("-------------------------------------");

            }
        }

    }
}


