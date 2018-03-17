using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoNET {
    public class FibModule {
        // calculate n-th term of fibbonaci sequence
        public ulong calc_nth_term_textbook(ulong n) {
            if (n == 0 || n == 1)
                return n;
            else
                return calc_nth_term_textbook(n - 1) + calc_nth_term_textbook(n - 2);
        }
        // classic calculation method for fibbonaci numbers
        // return the last term of calculations
        // for example if term is 0 and start_first is 0 and start_second is 1
        // it returns 1
        // if term is 1 returns also 1
        // if term is 4 returns 5
        /*
        public ulong calc_textbook_method_from(ulong start_first, ulong start_second, int term) {
            ulong result;

            if (start_first == null || start_second == null || term == null) {
                throw new ArgumentException("Arguments can't be null!");
            }

            if(term == 0)

        }
        */
    }
}
