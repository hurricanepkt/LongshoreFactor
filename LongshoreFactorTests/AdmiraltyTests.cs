using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    public class AdmiraltyTests
    {
        private Employer _employer;
        public AdmiraltyTests(Employer employer)
        {
            _employer = employer;
        }

        [Test]
        public void WithoutCrewNotAdmiralty()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: _employer, crew: false));

            Assert.IsFalse(vut.Admiralty);
        }
        [Test]
        public void WithCrewAdmiralty()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: _employer, crew: true));

            Assert.IsTrue(vut.Admiralty);
        }

        [Test]
        public void WithotCrewAdmiraltyWithSeaTrials()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: _employer, crew: false, seaTrials: true));

            Assert.IsTrue(vut.Admiralty);
        }


        [Test]
        public void WithoutCrewAdmiraltyWithVesselsInNavigation()
        {
            var vut = Calculator.Calculate(FactorCreator.Create(employer: _employer, crew: false, vesselsInNavigation: true));

            Assert.IsTrue(vut.Admiralty);
        }
    }
}