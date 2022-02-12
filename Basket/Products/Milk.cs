namespace Basket
{
    public class Milk : IProduct
    {
        private decimal _price { get; set; }
        
        public Milk()
        {
            _price = 1.15M;
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