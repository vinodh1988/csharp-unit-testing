using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Functions
    {

        public static int Add(int a, int b) {
            return a + b;
        }

        public static string GenId(string name, int sno) { 
            return name+ "_" + sno;
        }
    }
}
