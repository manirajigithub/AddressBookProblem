using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookProblem;

namespace AddressBookProblem
{
    public class PersonAddress
    {

        public List<Contact> persons = new List<Contact>();

        public void Book(Contact con)
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




