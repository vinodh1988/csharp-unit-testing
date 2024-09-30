using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests
{
   
    public class ItemTest
    {
        [Fact]
        public void ItemTestCheck() {
            Item i = new Item();
            Item i1 = new Item("Ram");
            Assert.Equal(i.GetName(), "NoName");
            Assert.Equal(i1.GetName(), "Ram");
        }
    }
}
