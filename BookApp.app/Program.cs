using BookApp.app.Services;
using BookLibrary.core.Models;

BookServices bookService = new BookServices();

Console.WriteLine("0.Close");

Console.WriteLine("1.Show Books");

Console.WriteLine("2.Create Book");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            bookService.ShowBooks();
            break;
        case "2":
            bookService.CreateBook();
            break;
        default:
            Console.WriteLine("Please, select valid option");
            break;
    }

    Console.WriteLine("0.Close");

    Console.WriteLine("1.Show Books");

    Console.WriteLine("2.Create Book");

    RequestNumber = Console.ReadLine();
}