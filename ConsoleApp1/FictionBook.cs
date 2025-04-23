using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Файл: FictionBook.cs
using ConsoleApp1;  // Подключаем пространство имен, где определен интерфейс IBook

namespace ConsoleApp1
{
    public class FictionBook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public FictionBook(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public string GetInfo()
        {
            return $"Жанр: {Genre}";
        }
    }
}






