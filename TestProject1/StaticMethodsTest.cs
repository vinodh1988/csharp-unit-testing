using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests
{
    [TestFixture]
    public class StaticMethodsTest
    {
        [Test]
        public void AddTest() {
            Assert.AreEqual(Functions.Add(2, 3), 5);
        }

        [Test]
        public void GenIdTest()
        {
            Assert.AreEqual(Functions.GenId("Raj", 134), "Raj_134");

        }
    }
}
