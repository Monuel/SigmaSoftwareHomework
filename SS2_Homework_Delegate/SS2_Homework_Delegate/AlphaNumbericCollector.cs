using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate
{
    class AlphaNumbericCollector
    {
        List<string> numberCollector = new List<string>();
        public AlphaNumbericCollector() { }
        public void CollectingMethod(string us)
        {
            numberCollector.Add(us);
        }
        public void Show()
        {
            foreach (string x in numberCollector)
            {
                Console.WriteLine(x);
            }
        }
    }
}
