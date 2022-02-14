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

            //calculate how much bread can be discounted
            var breadCountThatCanBeDiscounted = (int) Math.Floor((decimal) products.OfType<Butter>().Count() / 2);
            
            var breadProducts = products.OfType<Bread>();

            foreach (var bread in breadProducts)
            {
                if (breadCountThatCanBeDiscounted == 0)
                {
                    //no more bread can be discounted
                    break;
                }
                
                //keep discounting bread -> 50% off
                bread.SetPrice(ProductPrices.GetBreadPrice()/2);
                breadCountThatCanBeDiscounted--;
            }
        }
    }
}