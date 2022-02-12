using NUnit.Framework;

namespace Basket.Tests
{
    public class BasketTests
    {
        private IBasket _basket;
        
        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
        }

        [Test]
        public void WhenBasketEmpty_ThenTotalPriceShouldBeZero()
        {
            var expectedTotalPrice = 0.00M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasOneBreadOneMilkOneButter_ThenTotalPriceShouldBeTwoNinetyFive()
        {
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Bread());

            var expectedTotalPrice = 2.95M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasTwoButterTwoBread_ThenTotalPriceShouldBeThreeTen()
        {
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Bread());
            _basket.AddToCart(new Bread());
            
            var expectedTotalPrice = 3.10M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasFourMilk_ThenTotalPriceShouldBeThreeFourtyFive()
        {
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            
            var expectedTotalPrice = 3.45M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasTenMilk_ThenTotalPriceShouldBeNineTwenty()
        {
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            
            var expectedTotalPrice = 9.20M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasTwoButterOneBreadEightMilk_ThenTotalPriceShouldBeNine()
        {
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Bread());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            _basket.AddToCart(new Milk());
            
            var expectedTotalPrice = 9.00M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }

        [Test]
        public void WhenBasketHasFourButterTwoBread_ThenTotalPriceShouldBeFourTwenty()
        {
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Bread());
            _basket.AddToCart(new Bread());
            
            
            var expectedTotalPrice = 4.20M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }
        
        [Test]
        public void WhenBasketHasFourButterThreeBread_ThenTotalPriceShouldBeFiveTwenty()
        {
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Butter());
            _basket.AddToCart(new Bread());
            _basket.AddToCart(new Bread());
            _basket.AddToCart(new Bread());

            var expectedTotalPrice = 5.20M;
            var actualTotalPrice = _basket.GetTotalCost();
            
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
        }
    }
}