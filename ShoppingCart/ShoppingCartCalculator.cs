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
                result = books[0].Price * books[0].Count * discount;
            }
            else if (books.Count == 2)
            {
                discount = 0.95;

                double temptotal = 0;

                foreach (var item in books)
                {
                    temptotal += item.Price * item.Count;
                }

                result = temptotal * discount;
            }
            return result;
        }
    }
}
