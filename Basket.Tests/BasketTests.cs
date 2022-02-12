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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}