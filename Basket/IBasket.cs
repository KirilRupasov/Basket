namespace Basket
{
    public interface IBasket
    {
        void AddToCart(IProduct product);
        decimal GetTotalCost();
    }
}