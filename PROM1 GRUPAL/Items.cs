using System;
using System.Collections.Generic;

namespace PROM1_GRUPAL
{
    public class Items
    {
        private string name;
        private string description;

        public Items(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        private static List<Items> itemList = new List<Items>();

        public static List<Items> GetItems()
        {
            return new List<Items>(itemList); 
        }
        public static void AddItem(Items item)
        {
            itemList.Add(item);
        }
    }
}

