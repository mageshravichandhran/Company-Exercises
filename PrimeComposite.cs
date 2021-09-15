using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class PrimeComposite
    {
        int num;
        public PrimeComposite(int num)
        {
            this.num = num;
        }

        public bool CheckPrime()
        {


            bool is_composite = false;
            for (int i = 2; i < this.num; i++)
            {


                if (this.num % i == 0)
                {

                    is_composite = true;

                    break;
                }

            }

            if (is_composite)
            {
                //Console.WriteLine("The Given number is a composite number");
                return true;
            }
            else
            {
                //Console.WriteLine("The Given number is a prime number");
                return false;


            }
        }
    }
}
