using System;

namespace Basket
{
    public class Butter : IProduct
    {
        private decimal _price { get; set; }
        
        public Butter()
        {
            _price = 0.80M;
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