namespace Basket
{
    public class Milk : IProduct
    {
        private decimal _price { get; set; }
        
        public Milk()
        {
            _price = ProductPrices.GetMilkPrice();
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