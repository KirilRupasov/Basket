namespace Basket
{
    public class Bread : IProduct
    {
        private decimal _price { get; set; }

        public Bread()
        {
            _price = ProductPrices.GetBreadPrice();
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }
    }
}