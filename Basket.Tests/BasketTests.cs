using NUnit.Framework;

namespace Basket.Tests
{
    public class BasketTests
    {
        private Basket _basket;
        
        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
        }

        [Test]
        public void WhenBasketHasOneBreadOneMilkOneButter_ThenTotalPriceShouldBeTwoNinetyFive()
        {
            var milkCost = 1.15M;
            var butterCost = 0.80M;
            var breadCost = 1.00M;
            
            _basket.AddToCart(milkCost);
            _basket.AddToCart(butterCost);
            _basket.AddToCart(breadCost);

            var expectedTotalPrice = 2.95M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasTwoButterTwoBread_ThenTotalPriceShouldBeThreeTen()
        {
            var butterCost = 0.80M;
            var breadCost = 1.00M;
            
            _basket.AddToCart(butterCost);
            _basket.AddToCart(butterCost);
            _basket.AddToCart(breadCost);
            _basket.AddToCart(breadCost);
            
            var expectedTotalPrice = 3.10M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }
    }
}