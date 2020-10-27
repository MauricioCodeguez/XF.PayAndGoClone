using System.Collections.Generic;

namespace PayAndGoClone.Models
{
    public class ItemsGroup : List<ItemsCollection>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public ItemsGroup(
            string title,
            string description)
        {
            Title = title;
            Description = description;
        }
    }
}
