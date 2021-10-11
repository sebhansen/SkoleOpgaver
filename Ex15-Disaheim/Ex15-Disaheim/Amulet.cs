using System;
using System.Collections.Generic;
using System.Text;

namespace Ex15_Disaheim
{
    public class Amulet : Merchandise
    {
        //Merchandise merch = new Merchandise();
        public Level Quality{ get; set; }
        public string Design{ get; set; }

        public Amulet(string itemId) : this(itemId, Level.medium)
        {
            ItemId = itemId;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, "")
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
