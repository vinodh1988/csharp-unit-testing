using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests
{

    public class StaticMethodsTest
    {
        [Fact]
        public void AddTest() {
            Assert.Equal(Functions.Add(2, 3), 5);
        }

        [Fact]
        public void GenIdTest()
        {
            Assert.Equal(Functions.GenId("Raj", 134), "Raj_134");

        }
    }
}
