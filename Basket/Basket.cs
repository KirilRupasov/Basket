using System;
using System.Collections.Generic;
using System.Linq;

namespace Basket
{
    public class Basket : IBasket
    {
        private decimal _totalCost { get; set; }
        private IList<IProduct> _products { get; set; }
        
        public Basket() {
            _totalCost = 0.0M;
            _products = new List<IProduct>();
        }
        
        public void AddToCart(IProduct product) {
            _products.Add(product);
            _totalCost += product.GetPrice();
        }
        
        public decimal GetTotalCost()
        {
            ApplyOffers();
            return _products.Select(x => x.GetPrice()).Sum();
        }

        private void ApplyOffers()
        {
            if (_products.OfType<Butter>().Count() < 2) return;
            
            var bread = _products.OfType<Bread>().FirstOrDefault();

            if (bread != null)
            {
                _products.OfType<Bread>().FirstOrDefault()?.SetPrice(bread.GetPrice()/2);
            }
        }
    }
}