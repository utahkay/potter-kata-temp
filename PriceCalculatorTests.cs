using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Potter
{
    public class Tests
    {
        private PriceCalculator priceCalculator;

        [SetUp]
        public void Setup()
        {
            priceCalculator = new PriceCalculator();
        }

        [Test]
        public void One_book_costs_8_euro()
        {
            Assert.That(priceCalculator.Price(new int[] { 1 }), Is.EqualTo(8));
        }
        
        [Test]
        public void Two_different_books_5percent_off()
        {
            Assert.That(priceCalculator.Price(new int[] { 1, 2 }), Is.EqualTo(15.2m)); 
        }
        
        [Test]
        public void Three_different_books_10percent_off()
        {
            Assert.That(priceCalculator.Price(new int[] { 1, 2, 3 }), Is.EqualTo(21.6m));
        }

        [Test]
        public void Four_different_books_20percent_off()
        {
            Assert.That(priceCalculator.Price(new int[] { 1, 2, 3, 4 }), Is.EqualTo(25.6m));
        }

        [Test]
        public void Five_different_books_25percent_off()
        {
            Assert.That(priceCalculator.Price(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(30m));
        }

        [Test]
        public void Two_copies_same_book_no_discount()
        {
            Assert.That(priceCalculator.Price(new int[] { 1, 1 }), Is.EqualTo(16));
        }

        // [Test]
        // public void Two_copies_same_book_one_copy_different_book()
        // {
        //     Assert.That(priceCalculator.Price(new int[] { 1, 1, 2 }), Is.EqualTo(23.2m));
        // }

        [Test]
        public void One_book()
        {
            Assert.That(priceCalculator.CalculateSets(new List<int>() { 1 }), Is.EqualTo(new List<int>() { 1 } ));
        }
    }
}