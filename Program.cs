using System;

namespace AddressBookProblemUC3
{
    class program
    {
        public static void Main(string[] args)
        {
            Contact person = new Contact();

            PersonAddress GetPerson = new PersonAddress();
            GetPerson.Book();
            GetPerson.Show();
            GetPerson.EditContact();
            GetPerson.RemoveContact();
        }
    }
}
