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
                result = books[0].Price * books[0].Count * discount;
            }
            return result;
        }
    }
}
