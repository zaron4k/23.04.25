using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            IBook fictionBook = new FictionBook("Война и мир", "Лев Толстой", "Роман");
            IBook nonFictionBook = new NonFictionBook("Краткая история времени", "Стивен Хокинг", "Физика");
            IBook textbook = new Textbook("Алгебра 10", "Иванов И.И.", "Математика");
            library.AddBook(fictionBook);  
            library.AddBook(nonFictionBook);  
            library.AddBook(textbook);
            Console.WriteLine("Список книг в библиотеке:");
            library.ShowBooks();
            library.RemoveBook(nonFictionBook);
            Console.WriteLine("\nСписок книг в библиотеке после удаления научной книги:");
            library.ShowBooks();
            Console.Read();
        }
    }
}
