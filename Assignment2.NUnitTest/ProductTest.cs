
using NUnit.Framework.Internal;

namespace Assignment2.NUnitTest
{
    public class ProductTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase]
        // Product ID
        [Test]
        public void ProductId_MinValue()
        {
            var product = new Product(1, "TestName", 10, 5);
            Assert.AreEqual(1, product.ProductID);
        }

        [Test]
        public void ProductId_MidValue()
        {
            var product = new Product(5050, "TestName", 10, 5);
            Assert.AreEqual(5050, product.ProductID);
        }

        [Test]
        public void ProductId_MaxValue()
        {
            var product = new Product(9999, "TestName", 10, 5);
            Assert.AreEqual(9999, product.ProductID);
        }

        //Product name
        [Test]
        public void ProductName_ValidName()
        {
            var product = new Product(1, "Phone", 10, 5);
            Assert.AreEqual("Phone", product.ProductName);
        }
        [Test]
        public void ProductName_EmptyString()
        {
            var product = new Product(1, "", 10, 5);
            Assert.AreEqual("", product.ProductName);
        }
        [Test]
        public void ProductName_TwoName()
        {
            var product = new Product(1, "My Name", 10, 5);
            Assert.AreEqual("My Name", product.ProductName);
        }

        //Price
        [Test]
        public void ProductPrice_MinValue()
        {
            var product = new Product(1, "TestName", 0.5, 5);
            Assert.AreEqual(0.5, product.Price);
        }
        [Test]
        public void ProductPrice_MidValue()
        {
            var product = new Product(1, "TestName", 50.1, 5);
            Assert.AreEqual(50.1, product.Price);
        }
        [Test]
        public void ProductPrice_MaxValue()
        {
            var product = new Product(1, "TestName", 99.9, 5);
            Assert.AreEqual(99.9, product.Price);
        }

        //Stock
        [Test]
        public void ProductStock_MinValue()
        {
            var product = new Product(1, "TestName", 5, 1);
            Assert.AreEqual(1, product.Stock);
        }
        [Test]
        public void ProductStock_MidValue()
        {
            var product = new Product(1, "TestName", 5, 499);
            Assert.AreEqual(499, product.Stock);
        }
        [Test]
        public void ProductStock_MaxValue()
        {
            var product = new Product(1, "TestName", 5, 1001);
            Assert.AreEqual(1001, product.Stock);
        }

        //Incerease Method
        [Test]
        public void IncreasedMethod_MinValue()
        {
            var product = new Product(1, "TestName", 5, 10);
            product.IncreaseStock(1);
            Assert.AreEqual(11, product.Stock);
        }
        [Test]
        public void IncreasedMethod_MidValue()
        {
            var product = new Product(1, "TestName", 5, 100);
            product.IncreaseStock(49);
            Assert.AreEqual(149, product.Stock);
        }
        [Test]
        public void IncreasedMethod_MaxValue()
        {
            var product = new Product(1, "TestName", 5, 100);
            product.IncreaseStock(899);
            Assert.AreEqual(999, product.Stock);
        }

        //Decreased Method
        [Test]
        public void DecreasedMethod_MinValue()
        {
            var product = new Product(1, "TestName", 5, 2);
            product.DecreaseStock(1);
            Assert.AreEqual(1, product.Stock);
        }
        [Test]
        public void DecreasedMethod_MidValue()
        {
            var product = new Product(1, "TestName", 5, 100);
            product.DecreaseStock(50);
            Assert.AreEqual(50, product.Stock);
        }
        [Test]
        public void DecreasedMethod_MaxValue()
        {
            var product = new Product(1, "TestName", 5, 100);
            product.DecreaseStock(99);
            Assert.AreEqual(1, product.Stock);
        }

    }

}