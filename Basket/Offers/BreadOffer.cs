using System.Collections.Generic;
using System.Linq;

namespace Basket.Offers
{
    public class BreadOffer : IOffer
    {
        public void ApplyOffer(IList<IProduct> products)
        {
            if (products.OfType<Butter>().Count() < 2) return;
            
            products.OfType<Bread>().FirstOrDefault()?.SetPrice(ProductPrices.GetBreadPrice()/2);
        }
    }
}