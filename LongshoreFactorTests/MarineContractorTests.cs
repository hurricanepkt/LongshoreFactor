using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class MarineContractorTests : AdmiraltyTests
    {
        public MarineContractorTests()
            : base(Employer.MarineContractor)
        {

        }


        [Test]
        public void MarineContractorNotSeawalls()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.MarineContractor, seawalls: false));

            Assert.IsTrue(vut.Longshore);
        }


        [Test]
        public void MarineContractorSeawallsWithoutLoading()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.MarineContractor, seawalls: true, barge: false));

            Assert.IsFalse(vut.Longshore);
        }


        [Test]
        public void MarineContractorSeawallsWithLoading()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.MarineContractor, seawalls: true, barge: true));

            Assert.IsTrue(vut.Longshore);
        }

    }
}