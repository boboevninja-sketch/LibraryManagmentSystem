using LibraryManagmentSystem.Console.Interfaces;
using LibraryManagmentSystem.Console.Models;

namespace LibraryManagmentSystem.Console.Services
{
    internal class LibraryService: ILibraryService
    {
        private Book[] books = new Book[100];
        private int count = 0;

        public void AddBook(Book book)
        {
            books[count] = book;
            count++;

            System.Console.WriteLine("Kitob qo'shildi");
        }

        public void GetAllBooks()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(
                    books[i].Id + " - " +
                    books[i].Title + " - " +
                    books[i].Author + " - " +
                    (books[i].IsBorrowed ? "Band" : "Bo'sh")
                );
            }
        }

        public void BorrowBook(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Id == id)
                {
                    if (books[i].IsBorrowed)
                    {
                        System.Console.WriteLine("Kitob allaqachon band");
                    }
                    else
                    {
                        books[i].IsBorrowed = true;
                        System.Console.WriteLine("Kitob ijaraga berildi");
                    }
                    return;
                }
            }

            System.Console.WriteLine("Kitob topilmadi");
        }

        public void ReturnBook(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Id == id)
                {
                    books[i].IsBorrowed = false;
                    System.Console.WriteLine("Kitob qaytarildi");
                    return;
                }
            }

            System.Console.WriteLine("Kitob topilmadi");
        }
    }
}
