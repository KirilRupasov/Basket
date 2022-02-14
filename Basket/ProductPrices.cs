namespace Basket
{
    public static class ProductPrices
    {
        private static decimal _milkPrice = 1.15M;

        private static decimal _breadPrice = 1.00M;

        private static decimal _butterPrice = 0.80M;

        public static decimal GetMilkPrice()
        {
            return _milkPrice;
        }
        
        public static decimal GetBreadPrice()
        {
            return _breadPrice;
        }
        
        public static decimal GetButterPrice()
        {
            return _butterPrice;
        }
    }
}