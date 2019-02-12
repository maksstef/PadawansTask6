using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;

            if (number / 1000 >= 1)
            {
                n1 = number / 1000;
            }
            if ((number - n1 * 1000) / 100 >= 1)
            {
                n2 = (number - n1 * 1000) / 100;
            }
            if ((number - n2 * 100) / 10 >= 1)
            {
                n3 = (number - n1 * 1000 - n2 * 100) / 10;
            }
            n4 = number - n1 * 1000 - n2 * 100 - n3 * 10;

            if (n4 > n3)
                return n1 * 1000 + n2 * 100 + n4 * 10 + n3;
            else
            {
                if (n3 > n2)
                {
                    return n1 * 1000 + n3 * 100 + n2 * 10 + n4;
                }
                else
                {
                    if (n2 > n1)
                    {
                        return n2 * 1000 + n1 * 100 + n3 * 10 + n4;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
