

using LibraryManagmentSystem.Console.Interfaces;
using LibraryManagmentSystem.Console.Models;
using LibraryManagmentSystem.Console.Services;

ILibraryService library = new LibraryService();

while (true)
{
    Console.WriteLine("\n1. Kitob qo'shish");
    Console.WriteLine("2. Kitoblarni ko'rish");
    Console.WriteLine("3. Kitob ijaraga berish");
    Console.WriteLine("4. Kitob qaytarish");
    Console.WriteLine("5. Chiqish");

    Console.Write("Tanlang: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Book book = new Book();

            Console.Write("Id: ");
            book.Id = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            book.IsBorrowed = false;

            library.AddBook(book);
            break;

        case 2:
            library.GetAllBooks();
            break;

        case 3:
            Console.Write("Kitob ID: ");
            int borrowId = int.Parse(Console.ReadLine());

            library.BorrowBook(borrowId);
            break;

        case 4:
            Console.Write("Kitob ID: ");
            int returnId = int.Parse(Console.ReadLine());

            library.ReturnBook(returnId);
            break;

        case 5:
            return;
    }
}