using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NonFictionBook: IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Topic { get; set; }
        public NonFictionBook(string title, string author, string topic)
        {
            Title = title;
            Author = author;
            Topic = topic;
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
            return $"Тема: {Topic}";
        }
    }
}
