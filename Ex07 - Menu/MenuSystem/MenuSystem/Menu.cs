using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSystem
{
    class Menu
    {
        public string Title;
        private int itemCount = 0;

        private MenuItem[] menuItems = new MenuItem[30];
        /*
        public MenuItem[] MenuItems
        {
            get 
            {
                return menuItems; 
            }
            set 
            {
                menuItems = value;
            }
        }

        public int ItemCount
        {
            get 
            {
                return itemCount;
            }
            set 
            {
                itemCount = value;
            }
        }
        */
        public Menu (string title)
        {
            Title = title;
        }
        public void Show()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i] != null)
                {
                    Console.WriteLine(menuItems[i].Title);
                }
            }
            Console.WriteLine("\n(Tryk på menupunkt eller 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            menuItems[itemCount] = new MenuItem(menuTitle);
            itemCount++;
        }
    }
}
