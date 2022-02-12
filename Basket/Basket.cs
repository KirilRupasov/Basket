using System;
using System.Collections.Generic;
using System.Linq;
using Basket.Offers;

namespace Basket
{
    public class Basket : IBasket
    {
        private IList<IProduct> _products { get; set; }
        private IList<IOffer> _offers { get; set; }

        public Basket() {
            _products = new List<IProduct>();
            _offers = new List<IOffer>();
            _offers.Add(new BreadOffer());
            _offers.Add(new MilkOffer());
        }
        
        public void AddToCart(IProduct product) {
            _products.Add(product);
        }
        
        public decimal GetTotalCost()
        {
            foreach(var offer in _offers)
            {
                offer.ApplyOffer(_products);
            }
            
            return _products.Select(x => x.GetPrice()).Sum();
        }
    }
}