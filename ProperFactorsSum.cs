using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class ProperFactorsSum
    {
        int num;
        public ProperFactorsSum(int num)
        {
            this.num = num;
        }

      public int SumProperFact()

        {
            int sum = 0;
            for (int i = 2; i < this.num; i++)
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
