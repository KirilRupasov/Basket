namespace Basket
{
    public class Milk : IProduct
    {
        private const decimal _price = 1.15M;
        
        public decimal GetPrice()
        {
            return _price;
        }
    }
}