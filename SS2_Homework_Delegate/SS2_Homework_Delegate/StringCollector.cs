using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate
{
    class StringCollector
    {
        List<string> stringCollector = new List<string>();
        public StringCollector() { }
        public void CollectingMethod(string us)
        {
            stringCollector.Add(us);
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
