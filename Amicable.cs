using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Amicable
    {
        int num1;
        int num2;
        public Amicable(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
       static public int SumProperFact(int num)

        {
            int sum = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public bool isamicable()

        {
           

            return SumProperFact(this.num1) == SumProperFact(this.num2) ? true : false;
        }
    }
}
