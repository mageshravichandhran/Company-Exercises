using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Numbertype
    {
        int num;
        public Numbertype(int number)
        {
            this.num = number;
        }
        public int SumofFactorial()
        {
            int sum1= 0;
            while (this.num != 0)
            {
                int lastdigit = this.num % 10;
                int fact = 1;
                for(int i = 1; i <= lastdigit; i++)
                {
                    fact *= i;
                }

                sum1+= fact;
                this.num = this.num / 10;

            }

            return sum1;
        }

        public int SumofDigits()
        {
            int sum = 0;
            
            while (this.num != 0)
            {
               int dgt = this.num % 10;

                sum += dgt;

                this.num = this.num / 10;

                


           
            }
            while (sum >= 10)                                                       //Incompleted Program.
            {

                this.num = sum;
                this.SumofDigits();


            }
            return sum;

           
          
        }
         



        public void is_numtype()
        {
            if (this.SumofFactorial() == this.num)
            {
                Console.WriteLine("The Given Number is called a special number");
            }







        }

    }
}
