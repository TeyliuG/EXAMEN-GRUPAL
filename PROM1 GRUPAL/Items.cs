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
        private static List<Items> etemList = new List<Items>();

        public static List<Items> GetItems()
        {
            return new List<Items>(itemList);
        }
        public static List<Items> GetEtems()
        {
            return new List<Items>(etemList);
        }
        public static void AddItem(Items item)
        {
            itemList.Add(item);
        }
        public static void AddEtem(Items item)
        {
            etemList.Add(item);
        }
    }
}

