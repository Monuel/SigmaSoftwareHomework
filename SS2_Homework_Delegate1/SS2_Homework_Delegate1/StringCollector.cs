using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate1
{
    class StringCollector
    {
        List<string> stringCollector = new List<string>();
        public delegate void AlphaOperator(string us);
        public event AlphaOperator stringer;
        public StringCollector()
        {
            stringer += CollectingMethod;
        }
        public void CollectingMethod(string us)
        {
            stringCollector.Add(us);
        }
        public void Count(string us)
        {
            stringer(us);
        }
        public void Show()
        {
            foreach (string x in stringCollector)
            {
                Console.WriteLine(x);
            }
        }

    }
}
