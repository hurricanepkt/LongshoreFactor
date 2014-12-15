using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class YachtClub : AdmiraltyTests
    {
        public YachtClub() : base(Employer.YachtClub) { }
        [Test]
        public void YachtClubNonproftitNotLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.YachtClub, nonprofit : true));

            Assert.IsFalse(vut.Longshore);
        }

        public void YatchClubForProfitWithoutCommercialOrBigIsNotLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.YachtClub, 
                    nonprofit: false, 
                    commercialVessels: false, 
                    over65Ft: false));

            Assert.IsFalse(vut.Longshore);
        }



        [Test]
        public void YatchClubForProfitWithCommercialIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.YachtClub,
                nonprofit: false, 
                commercialVessels: true));

            Assert.IsTrue(vut.Longshore);
        }

        [Test]
        public void YatchClubForProfitWithBigIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.YachtClub,
                nonprofit: false,
                over65Ft: true));

            Assert.IsTrue(vut.Longshore);
        }
    }
}