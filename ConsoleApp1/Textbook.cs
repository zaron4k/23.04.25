using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Textbook:IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public Textbook (string title, string author, string subject)
        {
            Title = title;
            Author = author;
            Subject = subject;
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
            return $"Предмет: {Subject}";
        }
    }
}
