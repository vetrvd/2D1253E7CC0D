using CardSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSort.Tests
{
    class Metropolis: City
    {
        public Metropolis(string name): base(name)
        { }
    }

    [TestFixture]
    public class CityTests
    {
        [Test]
        public void City_Equals_Work1()
        {
            City city = null;

            Assert.AreEqual(null, city);
            Assert.AreEqual(city, null);
        }

        [Test]
        public void City_Equals_Work2()
        {
            City city = new City("Moscow");

            Assert.AreEqual(city, city);
        }

        [Test]
        public void City_Equals_Work3()
        {
            City city1 = new City("Moscow");
            City city2 = new City("Moscow");

            Assert.AreEqual(city1, city2);
        }

        [Test]
        public void City_Equals_Work4()
        {
            City city1 = new City("Moscow");
            City city2 = new City("Berlin");

            Assert.AreNotEqual(city1, city2);
        }

        [Test]
        public void City_Equals_Work5()
        {
            City city1 = new City("Moscow");
            Metropolis city2 = new Metropolis("Moscow");

            Assert.AreNotEqual(city1, city2);
        }
    }
}
