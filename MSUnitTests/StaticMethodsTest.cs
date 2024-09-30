using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests
{
    [TestClass]
    public class StaticMethodsTest
    {
        [TestMethod]
        public void AddTest() {
            Assert.AreEqual(Functions.Add(2, 3), 5);
        }

        [TestMethod]
        public void GenIdTest()
        {
            Assert.AreEqual(Functions.GenId("Raj", 134), "Raj_134");

        }
    }
}
