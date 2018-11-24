using System;
using System.Collections.Generic;
using System.Text;

namespace SS2_Homework_Delegate2
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
