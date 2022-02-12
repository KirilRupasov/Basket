using System;

namespace Basket
{
    public class Basket
    {
        private decimal _totalCost { get; set; }
        
        public Basket() {
            _totalCost = 0.0M;
        }
        
        public void AddToCart(IProduct product) {
            _totalCost += product.GetPrice();
        }
        
        public decimal GetTotalCost() {
            return _totalCost;
        }
    }
}