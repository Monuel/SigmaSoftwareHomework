using System;
using System.Collections.Generic;
using System.Text;

namespace SS2_Homework_Delegate2
{
    class StringGenerator
    {
        static void Add(List<string> list, string us)
        {
            list.Add(us);
        }
        static string AddElementToCollectionAlpha(AlphaNumbericCollector alpha, string x)
        {
            alpha.CollectingMethod(x);
            return x;
        }
        static string AddElementToStringAlpha(StringCollector @string, string x)
        {
            @string.CollectingMethod(x);
            return x;
        }
        public StringGenerator()
        {
            Start();
        }
        public void Start()
        {
            List<string> ptr = new List<string>();
            Predicate<string> isPositive = delegate (string x) {
                for (int i = 0; i < x.Length; i++)
                {
                    if (ptr[ptr.Count - 1][i] >= 0x30 && ptr[ptr.Count - 1][i] <= 0x39)
                    {
                        return true;
                    }
                    else if (i == ptr[ptr.Count - 1].Length - 1)
                    {
                        return false;
                    }
                }
                return false;
            };
            string p;
            Action<List<string>, string> addElement;
            Func<AlphaNumbericCollector, string, string> func = AddElementToCollectionAlpha;
            Func<StringCollector, string, string> func1 = AddElementToStringAlpha;
            addElement = Add;
            AlphaNumbericCollector alphaCollector = new AlphaNumbericCollector();
            StringCollector stringCollector = new StringCollector();
            while (true)
            {
                addElement(ptr, Console.ReadLine());
                if (ptr[ptr.Count - 1] != null)
                {
                    for (int i = 0; i < ptr[ptr.Count - 1].Length; i++)
                    {
                        if (isPositive(ptr[ptr.Count - 1]) == true)
                        {
                            p = AddElementToCollectionAlpha(alphaCollector, ptr[ptr.Count - 1]);
                            alphaCollector.Show();
                            break;
                        }
                        else
                        {
                            p = AddElementToStringAlpha(stringCollector, ptr[ptr.Count - 1]);
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
