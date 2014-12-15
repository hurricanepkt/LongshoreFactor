using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class CateringTests : AdmiraltyTests
    {
        public CateringTests() : base(Employer.Catering)
        {
            
        }
        [Test]
        public void CateringLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Catering));

            Assert.IsTrue(vut.Longshore);
        }
    }
}