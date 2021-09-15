using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class ProperFactors
    {
        int num;
        public ProperFactors(int num)
        {
            this.num = num;
        }


        public  void P_factors()
        {
            for (int i = 2; i < this.num; i++)
            {
                if (this.num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
