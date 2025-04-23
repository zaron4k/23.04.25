using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book); // добавление книги в список
        }
        public void RemoveBook(IBook book)
        {
            books.Remove(book);
        }

        public void ShowBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.GetTitle()}, Автор: {book.GetAuthor()}, {book.GetInfo()}");
            }
        }
    }
}
