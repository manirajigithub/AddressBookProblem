using System;

namespace AddressBookProblemUC2
{
    class program
    {
        public static void Main(string[] args)
        {
            Contact person = new Contact();

            PersonAddress GetPerson = new PersonAddress();
            GetPerson.Book(person);
            GetPerson.Show();
        }
    }
}
