using CardSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rhino.Mocks;

namespace CardSort.Tests
{
    [TestFixture]
    public class CardSortTests
    {
        [Test]
        public void CardSort_Sort_ArgumentException()
        {
            var cardSortService = new CardSortService(MockRepository.GenerateStub<ILogger>());
            Assert.Throws<ArgumentNullException>(()=> cardSortService.Sort(null));
        }

        [Test]
        public void CardSort_Sort_Work1()
        {
            var cardSortService = new CardSortService(MockRepository.GenerateStub<ILogger>());

            var result = cardSortService.Sort(new Card[]
            {
                new Card(new City("b"), new City("c")),
                new Card(new City("a"), new City("b")),
                new Card(new City("c"), new City("d")),
            });

            Assert.AreEqual(3, result.Length);

            Assert.AreEqual("a", result[0].From.Name);
            Assert.AreEqual("b", result[1].From.Name);
            Assert.AreEqual("c", result[2].From.Name);
        }
    }
}
