using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblemUC8
{
    class program
    {
        private static object addressBook;

        public static void Main(string[] args)
        {
            Contact person = new Contact();
            Console.WriteLine("Enter the City Name for Searchin Person City in Dictionary ");
            string cityName = Console.ReadLine();
            object value = addressBook.SearchingPersonInCity(cityName);
        }
    }
}


