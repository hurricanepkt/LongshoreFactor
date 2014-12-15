using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class BoatBuilderTests : AdmiraltyTests
    {
        public BoatBuilderTests() : base(Employer.BoatBuilder)
        {
            
        }
        [Test]
        public void BoatbuilderIsNotAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.BoatBuilder));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void BoatbuilderofCommercialVesselsIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.BoatBuilder, commercialVessels : true));

            Assert.IsTrue(vut.Longshore);
        }

        [Test]
        public void BoatbuilderofBigVesselsIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.BoatBuilder, over65Ft: true));

            Assert.IsTrue(vut.Longshore);
        }

     
    }
}

