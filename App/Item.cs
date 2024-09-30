using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Item
    {
        public string name;

        public Item(string name = "NoName") { 
           this.name = name; 
        }
        public string GetName() { return name; }
    }
}
