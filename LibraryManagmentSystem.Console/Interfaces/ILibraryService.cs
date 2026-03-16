using LibraryManagmentSystem.Console.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagmentSystem.Console.Interfaces
{
    internal interface ILibraryService
    {
        void AddBook(Book book);
        void GetAllBooks();
        void BorrowBook(int id);
        void ReturnBook(int id);
    }
}
