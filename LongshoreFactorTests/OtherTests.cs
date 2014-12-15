using System.Diagnostics.SymbolStore;
using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class OtherTests : AdmiraltyTests
    {
        public OtherTests()
            : base(Employer.Other)
        {

        }
        [Test]
        public void OtherIsNotAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other,  sec9023A: true));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void OtherWithoutExclusionsAlwaysLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: false));

            Assert.IsTrue(vut.Longshore);
        }

        [Test]
        public void OtherVendorNotLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: true));

            Assert.IsFalse(vut.Longshore);
        }

        [Test]
        public void OtherVendorsLoadingLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: true, loading: true));

            Assert.IsTrue(vut.Longshore);
        }

        [Test]
        public void OtherVendorPermanentLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: true ,vendorPermanent: true));

            Assert.IsTrue(vut.Longshore);
        }

        [Test]
        public void OtherVendorRepairLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: true, vendorRepair: true));

            Assert.IsTrue(vut.Longshore);
        }
        [Test]
        public void OtherVendorSimilarLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Other, sec9023A: false, vendor: true, vendorSimilar: true));

            Assert.IsTrue(vut.Longshore);
        }
    }
}