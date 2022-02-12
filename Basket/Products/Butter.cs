using System;

namespace Basket
{
    public class Butter : IProduct
    {
        private const decimal _price = 0.80M;
        
        public decimal GetPrice()
        {
            return _price;
        }
    }
}