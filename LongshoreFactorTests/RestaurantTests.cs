using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class RestaurantTests: AdmiraltyTests
    {
        public RestaurantTests() : base(Employer.Restaurant)
        {
            
        }
        [Test]
        public void RestaurantLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Restaurant));

            Assert.IsFalse(vut.Longshore);
        }

     
    }
}