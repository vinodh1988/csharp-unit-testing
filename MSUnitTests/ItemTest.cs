using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemTestCheck() {
            Item i = new Item();
            Item i1 = new Item("Ram");
            Assert.AreEqual(i.GetName(), "NoName");
            Assert.AreEqual(i1.GetName(), "Ram");
        }
    }
}
