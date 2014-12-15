using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class StevedoreTests : AdmiraltyTests
    {
        public StevedoreTests() : base(Employer.Shipyard)
        {
            
        }
        [Test]
        public void StevedoreIsAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Shipyard));

            Assert.IsTrue(vut.Longshore);
        }

   
    }
}