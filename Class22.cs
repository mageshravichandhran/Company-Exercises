using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class FactorialSum1
    {
        int powerlimit;
        int x;
        public FactorialSum1(int powerlimit, int x)
        {
            this.powerlimit = powerlimit;
            this.x = x;
        }


        public int PowerCalc()
        {

            int i = 1;
            int result = 0;
            while (i <= this.powerlimit )
            {

                int j = 1;
                int mul = 1;
                while ( i >= j && i%2!=0  ){
                    mul *= this.x;
                    j += 1;
                }

                if (j % 2 == 0)
                {
                    result -= mul;
                }
                result += mul;
                i += 1;
             
            }


            return result;
            
        }

    }
}
