using System;
using System.Collections.Generic;
using System.Text;

namespace Ex15_Disaheim
{
    public class Book : Merchandise
    {
        //Merchandise merch = new Merchandise();
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId)
        {
            ItemId = itemId;
        }
        public Book(string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
