using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class VesselTests : AdmiraltyTests
    {
        public VesselTests() : base(Employer.Vessel)
        {
            
        }

        [Test]
        public void VesselEmployeeDocksideWorkIsLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Vessel, docksideEmp: true));

            Assert.IsTrue(vut.Longshore);
        }
        [Test]
        public void VesselNoEmployeeDocksideWorkIsNotLS()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: Employer.Vessel, docksideEmp: false));

            Assert.IsFalse(vut.Longshore);
        }
    }
}