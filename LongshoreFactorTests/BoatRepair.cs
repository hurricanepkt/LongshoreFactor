using LongshoreFactor;
using NUnit.Framework;
namespace LongshoreFactorTests
{
    [TestFixture]
    public class BoatRepair : AdmiraltyTests
    {
        public BoatRepair() : base(Employer.BoatRepair)
        {
            
        }
        [Test]
        public void BoatRepairIsNotAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.BoatRepair));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void BoatRepairofCommercialVesselsIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.BoatRepair, commercialVessels : true));

            Assert.IsTrue(vut.Longshore);
        }

    }
}