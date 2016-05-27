using System.Collections.Generic;

namespace PrimeFactor
{
    public class PrimeFactor
    {
        public int[] GetPrimeFactor(int num)
        {
            var list = new List<int>();

            int o;
            var r = GetPrimeFactor(num, 2, out o);
            if (r)
            {
                list.Add(2);
            }

            if (o == 0)
            {
                return list.ToArray();
            }

            return list.ToArray();
        }

        private bool GetPrimeFactor(int num, int n, out int o)
        {
            if (num % n == 0)
            {
                o = num / n;
                return true; ;
            }

            o = num;
            return false;
        }
    }
}
