using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LongshoreFactor;
using NUnit.Framework;

namespace LongshoreFactorTests
{
    [TestFixture]
    public class LongshoreFactorTests
    {
        [Test]
        public void AlwaysWorkComp()
        {
            var vut = Calculator.Calculate(FactorCreator.Create());

            Assert.IsTrue(vut.StateActWorkersComp);
        }

        
    }
}
