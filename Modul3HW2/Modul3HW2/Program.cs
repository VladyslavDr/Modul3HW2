using System;
using System.Globalization;

namespace Modul3HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new ListContact();

            book.Add(new Contact { FirstName = "Vlad", LastName = "Dr" });
            book.Add(new Contact { FirstName = "456", LastName = "fds" });
            book.Add(new Contact { LastName = "asddas" });

            foreach (var contact in book)
            {
                Console.WriteLine($"key: {contact.GetKey()}, FirstName: {contact.FirstName}, LastName: {contact.LastName}");
            }
        }
    }
}
