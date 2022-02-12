namespace Basket
{
    public interface IProduct
    {
        decimal GetPrice();
        void SetPrice(decimal price);
    }
}