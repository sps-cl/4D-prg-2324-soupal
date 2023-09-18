using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal abstract class LibraryItem<T>
    {
        private int Id { get; }
        private string Title { get; }
        private bool IsAvailable { get; }

        public LibraryItem(int id, string title)
        {
            Id = id;
            Title = title;
            IsAvailable = true;
        }

        public abstract void DisplayInfo ();
    }
}
