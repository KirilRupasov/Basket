using System;
using System.Collections.Generic;
using System.Linq;

namespace Basket.Offers
{
    public class MilkOffer : IOffer
    {
        public void ApplyOffer(IList<IProduct> products)
        {
            if (products.OfType<Milk>().Count() < 4) return;

            var milkProducts = products.OfType<Milk>();

            var i = 1;

            foreach (var milk in milkProducts)
            {
                if (i == 4)
                {
                    milk.SetPrice(0.00M);
                    i = 1;
                }
                
                i++;
            }
        }
    }
}