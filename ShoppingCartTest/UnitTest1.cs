﻿using System;
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

        [TestMethod]
        public void 情境二第一集1本_第二集1本_預期190元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 1 }
            };
            var expected = 190;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 情境三第一集1本_第二集1本_第三集1本_預期270元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 1 },
                new Book { Name="Vol_3" , Price = 100 , Count = 1 }
            };
            var expected = 270;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 情境四第一集1本_第二集1本_第三集1本_第四集1本_預期320元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 1 },
                new Book { Name="Vol_3" , Price = 100 , Count = 1 },
                new Book { Name="Vol_4" , Price = 100 , Count = 1 }
            };
            var expected = 320;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 情境五第一集1本_第二集1本_第三集1本_第四集1本_第五集1本_預期375元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 1 },
                new Book { Name="Vol_3" , Price = 100 , Count = 1 },
                new Book { Name="Vol_4" , Price = 100 , Count = 1 },
                new Book { Name="Vol_5" , Price = 100 , Count = 1 }
            };
            var expected = 375;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 情境六第一集1本_第二集1本_第三集2本_預期370元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 1 },
                new Book { Name="Vol_3" , Price = 100 , Count = 2 }
            };
            var expected = 370;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 情境七第一集1本_第二集2本_第三集2本_預期460元()
        {
            var books = new List<Book>
            {
                new Book { Name="Vol_1" , Price = 100 , Count = 1 },
                new Book { Name="Vol_2" , Price = 100 , Count = 2 },
                new Book { Name="Vol_3" , Price = 100 , Count = 2 }
            };
            var expected = 460;

            var shoppingCartCalculator = new ShoppingCartCalculator();
            var actual = shoppingCartCalculator.CalculateTotal(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
