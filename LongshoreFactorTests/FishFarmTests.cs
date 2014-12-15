using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class FishFarmTests : AdmiraltyTests
    {
        public FishFarmTests()
            : base(Employer.FishFarm)
        {

        }


        [Test]
        public void FishfarmNotControlledEnviroment()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.FishFarm, controlledEnviroment: false));

            Assert.IsTrue(vut.Longshore);
        }


        [Test]
        public void FishfarmControlledEnviromentWithoutLoading()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.FishFarm, controlledEnviroment: true, loading: false));

            Assert.IsFalse(vut.Longshore);
        }


        [Test]
        public void FishfarmControlledEnviromentWithLoading()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.FishFarm, controlledEnviroment: true, loading: true));

            Assert.IsTrue(vut.Longshore);
        }

    }
}