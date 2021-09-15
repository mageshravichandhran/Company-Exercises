using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class FactorsCount
    {
        int num;
        public FactorsCount(int num)
        {
            this.num = num;
        }

        public int N_factors()
        {
            int count = 0;
            for (int i = 1; i <= this.num; i++)
            {
                if (this.num % i == 0)
                {
                    count += 1;
                }
            }

            return count;
        }

    }
}
