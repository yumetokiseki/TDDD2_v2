using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ShoppingCart;

namespace ShoppingCartTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 情境一第一集1本_預期100元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 }
            };
            var expected = 100;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
