using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Factors

    {
        int num;
        public Factors(int num)
        {
            this.num = num;
        }

       public void factorsN()
        {
            for (int i = 1; i <= this.num; i++)
            {
                if (this.num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
