using System.Collections.Generic;
using System.Linq;

namespace Basket.Offers
{
    public class MilkOffer : IOffer
    {
        public void ApplyOffer(IList<IProduct> products)
        {
            if (products.OfType<Milk>().Count() < 4) return;
            
            products.OfType<Milk>().FirstOrDefault()?.SetPrice(0.00M);
        }
    }
}