using System;
using System.Collections.Generic;
using System.Text;

namespace Ex15_Disaheim
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }
        //public Merchandise() { }
        //public Merchandise(string itemId)
        //{
        //    ItemId = itemId;
        //}

        public override string ToString()
        {
            return ($"ItemId: {ItemId}");
        }
    }
}
