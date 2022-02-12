namespace Basket
{
    public class Bread : IProduct
    {
        private decimal _price { get; set; }

        public Bread()
        {
            _price = 1.00M;
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