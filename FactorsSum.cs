using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class FactorsSum
    {
        int num;
        public FactorsSum(int num)
        {
            this.num = num;

        }



        public int factorSum()
        {
            int sum = 0;
            for (int i = 1; i <= this.num; i++)
            {
                if (this.num % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
