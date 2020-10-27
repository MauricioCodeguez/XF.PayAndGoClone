using System.Collections.Generic;

namespace PayAndGoClone.Models
{
    public class ItemsCollection
    {
        public List<Items> Items { get; private set; }

        public ItemsCollection()
        {
            Items = new List<Items>();
        }

        public void Add(Items item)
        {
            Items.Add(item);
        }
    }
}