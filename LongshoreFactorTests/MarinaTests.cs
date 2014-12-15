using System;
using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class MarinaTests
    {
        [Test]
        public void MarinaIsNotAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void MarinaConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina, construction: true));

            Assert.IsTrue(vut.Longshore);
        }


        [Test]
        public void TrueMarinaCommercialNoConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina,
                construction: false, 
                trueMarina: true, 
                commercialVessels: true));

            Assert.IsTrue(vut.Longshore);
        }


        [Test]
        public void TrueMarinaNoCommercialYesBigNoConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina,
                construction: false,
                trueMarina: true,
                commercialVessels: false,
                over65Ft: true));

            Assert.IsTrue(vut.Longshore);
        }
        [Test]
        public void TrueMarinaNoCommercialNoBigNoConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina,
                construction: false,
                trueMarina: true,
                commercialVessels: false,
                over65Ft: false));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void RepairYardNoCommercialNoConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina,
                construction: false,
                trueMarina: false,
                commercialVessels: false));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void RepairYardYesCommercialNoConstruction()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Marina,
                construction: false,
                trueMarina: false,
                commercialVessels: true));

            Assert.IsTrue(vut.Longshore);
        }
    }
}