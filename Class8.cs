using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class DoubleFactorial
    {
        public DoubleFactorial()
        {

        }
        public int DoubleFactorialEven(int num) {

            int product = 1;
            for(int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i;
                }
            }
            return product;
        }

        public int DoubleFactorialOdd(int num)
        {
            int product = 1;
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    product *= i;
                }
            }
            return product;
        }
    }
}
