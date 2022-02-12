using System;

namespace Basket
{
    public class Basket
    {
        private decimal _totalCost { get; set; }
        
        public Basket() {
            _totalCost = 0.0M;
        }
        
        public void AddToCart(decimal productPrice) {
            _totalCost += productPrice;
        }
        
        public decimal GetTotalCost() {
            return _totalCost;
        }
    }
}