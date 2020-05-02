using System.Collections.Generic;
using System.Linq;

namespace Potter
{
    public class PriceCalculator
    {
        const decimal BaseBookPrice = 8m;
        readonly Dictionary<int, decimal> discountRates = new Dictionary<int, decimal>() 
        { 
            {1, 0.00m},
            {2, 0.05m},
            {3, 0.10m},
            {4, 0.20m},
            {5, 0.25m}
        };

        public decimal Price(int[] purchasedBooks)
        {
            var discount = 0m;
            var numOfBooks = purchasedBooks.Length;

            if (new List<int>(purchasedBooks).Distinct().Count() == numOfBooks)
            {
                discount = discountRates[numOfBooks];
            }
            else
            {
                CalculateSets(new List<int>(purchasedBooks));
                
            }

            return BaseBookPrice * numOfBooks * (1 - discount);
        }

        public List<int> CalculateSets(List<int> purchasedBooks)
        {
            
            return new List<int>() { 1 };
        }
    }
}