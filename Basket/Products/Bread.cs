namespace Basket
{
    public class Bread : IProduct
    {
        private const decimal _price = 1.00M;

        public decimal GetPrice()
        {
            return _price;
        }
    }
}