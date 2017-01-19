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

            List<Book> bookstemp = new List<Book>(books);
            while(bookstemp.Count>0)
            {
                if (bookstemp.Count == 1)
                {
                    discount = 1.0;
                }
                else if (bookstemp.Count == 2)
                {
                    discount = 0.95;
                }
                else if (bookstemp.Count == 3)
                {
                    discount = 0.9;
                }
                else if (bookstemp.Count == 4)
                {
                    discount = 0.8;
                }
                else if (bookstemp.Count == 5)
                {
                    discount = 0.75;
                }

                result += CalculateTotal(bookstemp, discount);

                List<Book> booksGrouptemp = new List<Book>(bookstemp);

                foreach (var tempItem in bookstemp)
                {
                    if (tempItem.Count > 1)
                    {
                        tempItem.Count = tempItem.Count - 1;
                    }
                    else if (tempItem.Count == 1)
                    {
                        booksGrouptemp.Remove(tempItem);
                    }
                }

                bookstemp = booksGrouptemp;
            }




            return result;
        }

        private static double CalculateTotal(List<Book> books, double discount)
        {
            double temptotal = 0;

            foreach (var item in books)
            {
                temptotal += item.Price ;
            }

            return temptotal * discount;
        }
    }
}
