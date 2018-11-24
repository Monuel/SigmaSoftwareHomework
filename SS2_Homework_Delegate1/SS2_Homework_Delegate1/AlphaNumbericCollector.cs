using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate1
{
    class AlphaNumbericCollector
    {
        public delegate void AlphaOperator(string us);
        public event AlphaOperator alpha;
        List<string> numberCollector = new List<string>();
        public AlphaNumbericCollector()
        {
            alpha += CollectingMethod;
        }
        public void Count(string us)
        {
            alpha(us);
        }
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
