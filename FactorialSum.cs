using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Factorialsum

    {
        
        public Factorialsum()
        {
           
        }


        public int factorial(int num)
        {

            int fact = 1;
            int i = 1;
            while ( i<= num) {
                fact *= i;
                i += 1;
            }

            return fact;

        }

        public int factsum(int limit)
        {

            int i = 1;
            int sum = 0;

            while (i <= limit) { 
                if (i % 2 != 0)
                {
                    sum += factorial(i);
                   
                  
                }
                i += 1;
            }

            return sum;
        }


    }
}
