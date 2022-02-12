using System.Collections.Generic;

namespace Basket.Offers
{
    public interface IOffer
    {
        void ApplyOffer(IList<IProduct> products);
    }
}