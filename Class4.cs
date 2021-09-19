using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class LCMGCD
    {
        public LCMGCD()
        {

        }
        public int Gcd(int num1,int num2)
        {
            int gcdresult = 0;
            int min = num1 > num2 ? num2 : num1;
             for(int i = 1; i <= min; i++)
             {
                if(num1%i==0 && num2 % i == 0)
                {
                     gcdresult = i;
                }
             }

            return gcdresult;
           
        }
        public int Lcm(int num1, int num2)
        {
            return ((num1 * num2) / Gcd(num1, num2));
        }
    }
}
