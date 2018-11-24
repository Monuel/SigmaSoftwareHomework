using System;
using System.Collections.Generic;

namespace SS2_Homework_Delegate1
{
    class StringGenerator
    {
        public static event Action added;
        public StringGenerator()
        {
            Start();
        }
        public void Start()
        {
            List<string> ptr = new List<string>();
            AlphaNumbericCollector alphaCollector = new AlphaNumbericCollector();
            StringCollector stringCollector = new StringCollector();
            while (true)
            {
                ptr.Add(Console.ReadLine());
                if (ptr[ptr.Count - 1] != null)
                {
                    for (int i = 0; i < ptr[ptr.Count - 1].Length; i++)
                    {
                        if (ptr[ptr.Count - 1][i] >= 0x30 && ptr[ptr.Count - 1][i] <= 0x39)
                        {
                            alphaCollector.Count(ptr[ptr.Count - 1]);
                            alphaCollector.Show();
                            break;
                        }
                        else if (i == ptr[ptr.Count - 1].Length - 1)
                        {
                            stringCollector.Count(ptr[ptr.Count - 1]);
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
    }
}
