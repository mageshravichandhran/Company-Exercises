using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Numtype
    {
        int num;

        public Numtype(int num)
        {
            this.num = num;


        }


        public void numtype()
        {


            FactorsSum Fs = new FactorsSum(this.num);
            int sum_num = Fs.factorSum();

            if (sum_num < this.num * 2)
            {
                Console.WriteLine("deficient");
            }

            else if (sum_num > this.num * 2)
            {
                Console.WriteLine("abudant");
            }

            else if (sum_num == this.num)
            {

                Console.WriteLine("perfect");
            }

        }
    }
}
