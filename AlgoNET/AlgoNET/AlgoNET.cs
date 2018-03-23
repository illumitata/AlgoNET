using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgoNET {

    public interface IFibModule
    {
        ulong textbook(ulong n);
        BigInteger fast_doubling(ulong n);
        List<String> get_values_from_range(ulong a, ulong b);
    }
    public class FibModule : IFibModule {
        // calculate n-th term of fibbonaci sequence
        public ulong textbook(ulong n) {
            if (n > 40)
                throw new System.ArgumentException("Parameter cannot be more than 40 due to long time of execution.", "n param too big");

            if (n == 0 || n == 1)
                return n;
            else
                return textbook(n - 1) + textbook(n - 2);
        }

        // calculate n-th term of fibbonaci sequence using fast doubling method
        public BigInteger fast_doubling(ulong n) {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
 
            for (int i = 63; i >= 0; i--) {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if (((n >> i) & 1) != 0) {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }

            return a;
        }

        // return the list of string with values from a to b fibbonaci numbers
        public List<String> get_values_from_range(ulong a, ulong b) {

            if (a > b)
                throw new System.ArgumentException("b cannot be more than a", "b param too small");

            List<String> list = new List<String>();

            for (ulong i = a; i <= b; i++) {
                list.Add(fast_doubling(i).ToString("D"));
            }

            return list;
        }
    }
}
