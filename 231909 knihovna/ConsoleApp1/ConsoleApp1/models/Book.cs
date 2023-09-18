using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Book : LibraryItem<Book>
    {
        public int NumberOfPages { get; }
        public string Author { get; }

        public Book(int numberofpages, string author, int id, string title) : base(id, title)
        {
            this.NumberOfPages = numberofpages;
            this.Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author}, pocet stran {NumberOfPages}");
        }
    }
}
