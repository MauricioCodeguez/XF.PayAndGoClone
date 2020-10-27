namespace PayAndGoClone.Models
{
    public class Items
    {
        public Items(string imageUrl, string title, decimal price, bool hasOffer, decimal percentOff, decimal valueOff)
        {
            ImageUrl = imageUrl;
            Title = title;
            Price = price;
            HasOffer = hasOffer;
            PercentOff = percentOff;
            ValueOff = valueOff;
        }

        public string ImageUrl { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool HasOffer { get; private set; }
        public decimal PercentOff { get; private set; }
        public decimal ValueOff { get; private set; }
    }
}