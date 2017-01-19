using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingCartCalculator
    {
        public double CalculateTotal(List<Book> books)
        {
            double result = 0;
            double discount = 1.0;

            if (books.Count == 1)
            {
                discount = 1.0;
            }
            else if (books.Count == 2)
            {
                discount = 0.95;
            }
            else if (books.Count == 3)
            {
                discount = 0.9;
            }
            else if (books.Count == 4)
            {
                discount = 0.8;           
            }

            result = CalculateTotal(books, discount);

            return result;
        }

        private static double CalculateTotal(List<Book> books, double discount)
        {
            double temptotal = 0;

            foreach (var item in books)
            {
                temptotal += item.Price * item.Count;
            }

            return temptotal * discount;
        }
    }
}
