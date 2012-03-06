using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.NumberSource
{
    public class ConsoleBasedNumberSource : IEnumerable<int>
    {
        readonly int _rangeBottom;
        readonly int _rangeTop;

        public ConsoleBasedNumberSource()
        {
            Console.WriteLine("Enter a number for the lower bound");
            _rangeBottom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number for the upper bound");
            _rangeTop = int.Parse(Console.ReadLine());
        }

        public IEnumerator<int> GetEnumerator()
        {
            var count = _rangeTop - _rangeBottom + 1;
            return Enumerable.Range(_rangeBottom, count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}