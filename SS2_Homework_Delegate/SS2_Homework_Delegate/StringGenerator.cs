using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate
{
    public delegate void AlphaOperation(string us);
    public delegate void StringOperation(string us);
    class StringGenerator
    {
        public void Start()
        {
            bool isStarted = true;
            List<string> ptr = new List<string>();
            AlphaNumbericCollector alphaCollector = new AlphaNumbericCollector();
            StringCollector stringCollector = new StringCollector();
            while (isStarted)
            {
                ptr.Add(Console.ReadLine());
                if (ptr[ptr.Count - 1] != null)
                {
                    for (int i = 0; i < ptr[ptr.Count - 1].Length; i++)
                    {
                        if (ptr[ptr.Count - 1][i] >= 0x30 && ptr[ptr.Count - 1][i] <= 0x39)
                        {
                            AlphaOperation alpha_operation = alphaCollector.CollectingMethod;
                            alpha_operation(ptr[ptr.Count - 1]);
                            alphaCollector.Show();
                            break;
                        }
                        else if (i == ptr[ptr.Count - 1].Length - 1)
                        {
                            StringOperation string_operation = stringCollector.CollectingMethod;
                            string_operation(ptr[ptr.Count - 1]);
                            stringCollector.Show();
                            break;
                        }
                    }
                }
                else
                {
                    ptr.Remove(ptr[ptr.Count - 1]);
                }
            }
        }
        public StringGenerator()
        {
            Start();
        }
    }
}
