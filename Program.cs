using System;
namespace AddressBookProblemUC5
{
    class program
    {
        public static void Main(string[] args)
        {
            Contact person = new Contact();

            PersonAddress GetPerson = new PersonAddress();
            GetPerson.Book();
            GetPerson.Show();
            GetPerson.Remove();
            GetPerson.EditContact();
        }

        
    }
}






