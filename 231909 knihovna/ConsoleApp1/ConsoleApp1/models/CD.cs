using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class CD : LibraryItem<CD>
    {
        public int Lenght { get; }
        public string Director { get; }

        public CD(int lenght, string director) : base (id,title)
        {
            this.Lenght = lenght;
            this.Director = director;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Director}, doba poslechu {Lenght}");
        }
    }
}
