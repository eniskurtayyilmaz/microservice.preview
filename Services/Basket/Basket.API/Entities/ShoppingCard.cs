namespace Basket.API.Entities
{
    public class ShoppingCard
    {
        public ShoppingCard()
        {

        }

        public string UserName { get; set; }
        public List<ShoppingCardItem> Items { get; set; } = new List<ShoppingCardItem>();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }
    }

}