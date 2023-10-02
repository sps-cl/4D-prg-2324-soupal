using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.models;
using LibraryApp.exceptions;

namespace LibraryApp
{
    internal class Library<T> where T : LibraryItem<T>
    {
        List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }

        public void ListItems()
        {
            Console.WriteLine("Knihovní předměty: ");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }

        public void CheckoutItem(int id)
        {
            T itemCheckout = items.Find(item=>item.Id == id);
            if (itemCheckout == null)
            {
                if (itemCheckout.IsAvailable)
                {
                    itemCheckout.IsAvailable = false;
                    Console.WriteLine($"Vypůjčit si knížku: { itemCheckout.Title} ");
                }
                else
                {
                    throw new NotAvailableException($"Položka s ID: {itemCheckout.Id} nebyla nalezena");
                }
            }
            else
            {
                throw new NotFoundException(); 

            }
        }
        public void Returnitem(int id)
        {

        }

    }
}
