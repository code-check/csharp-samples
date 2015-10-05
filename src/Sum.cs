using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest.src
{
    public class Sum
    {
        public int Sum1()
        {
            // Get the sum of all the numbers in 'List1'
            return Defaults.List1.Sum();
        }

        public int Sum2()
        {
            // Get the sum of all uneven numbers in 'List1'
            return Defaults.List1
                .Where(x => (x & 1) == 1)
                .Sum();
        }

        public int Sum3()
        {
            // 1) Combine 'List1' and 'List2'
            // 2) Get the sum of all uneven numbers
            return Defaults.List1
                .Concat(Defaults.List2)
                .Where(x => (x & 1) == 1)
                .Sum();
        }

        public int Sum4()
        {
            // Count the total of digits in 'List2'
            return Defaults.List2
                .Sum(x => x.ToString().Length);
        }

        public int Sum5()
        {
            // 1) Multiply all numbers in 'List1' with the last 5 items of 'List2'
            // 2) Get the Sum
            var last10 = Defaults.List2.Reverse().Take(5);
            return Defaults.List1
                .Select(x => last10.Aggregate(0, (left, right) => left + (right * x)))
                .Sum();
        }
    }
}
