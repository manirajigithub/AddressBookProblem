using System;
namespace AddressBookProblemUC5
{
    class program
    {
        public static void Main(string[] args)
        {
            Contact person = new Contact();
            Console.WriteLine("Enter the City Name for Searchin Person City in Dictionary ");
            string cityName = Console.ReadLine();
            addressBook.SearchingPersonInCity(cityName);
        }
    }
}
