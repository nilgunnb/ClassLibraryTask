

using BookLibrary.core.Models;
using System.Security.Cryptography.X509Certificates;

namespace BookApp.app.Services
{
    internal class BookServices
    {
        private Book[] Books = new Book[0];

        public void ShowBooks()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("Not available Books");
            }
            foreach (var book in Books)
            {
                book.GetFullInfo();
            }
        }

        public void CreateBook()
        {
            Book NewBook = new Book();

            Console.WriteLine("Please, add Name");


            NewBook.Name = Console.ReadLine();

           

            while (string.IsNullOrWhiteSpace(NewBook.Name))
            {
                Console.WriteLine("Please, add valid name");

                NewBook.Name = Console.ReadLine();

            }

         


            Console.WriteLine("Please, add Price");

           
       
            string numberstring = Console.ReadLine();

            NewBook.Price = double.Parse(numberstring);

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = NewBook;

        }
    }
}
