using System;
using System.Collections.Generic;
using System.Linq;

namespace Basket.Offers
{
    public class BreadOffer : IOffer
    {
        public void ApplyOffer(IList<IProduct> products)
        {
            if (products.OfType<Butter>().Count() < 2) return;

            var breadCountThatCanBeDiscounted = (int) Math.Floor((decimal) products.OfType<Butter>().Count() / 2);
            var breadProducts = products.OfType<Bread>();

            foreach (var bread in breadProducts)
            {
                if (breadCountThatCanBeDiscounted == 0)
                {
                    break;
                }
                
                bread.SetPrice(ProductPrices.GetBreadPrice()/2);
                breadCountThatCanBeDiscounted--;
            }
        }
    }
}