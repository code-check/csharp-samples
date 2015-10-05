using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest.src
{
    public static class Defaults
    {
        public static IEnumerable<int> List1 = Enumerable.Range(0, 1000);
        public static IEnumerable<int> List2 = Enumerable.Range(60, 100);
    }
}
