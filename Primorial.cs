using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Primorial
    {
        int num;
        public Primorial(int num)
        {
            this.num = num;
        }

        public int PrimorialVal()
        {
            PrimeComposite Pc = new PrimeComposite(this.num);

            bool iscomposite = Pc.CheckPrime();
            int mulval = 1;
            for (int i = 2; i <= this.num; i++)
            {
                if (!iscomposite)
                {
                    Console.WriteLine(i);
                    mulval *= i;
                }

            }
            return mulval;
        }
    }
}
