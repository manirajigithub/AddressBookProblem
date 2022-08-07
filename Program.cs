using System;

namespace AddressBookProblemUC4
{
    class program
    {
        public static void Main(string[] args)
        {

            Contact person = new Contact();

            PersonAddress GetPerson = new PersonAddress();
            GetPerson.Book();
            GetPerson.Show();
            GetPerson.RemoveContact();
        }
    }
}






