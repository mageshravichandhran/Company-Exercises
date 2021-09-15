using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Convert1
    {

        public static int ToDecimal(int num)
        {


            int DecimalValue = 0;
            int i = 0;

            while (num != 0)

            {
                int dgt = num % 10;
                Square S1 = new Square(2, i);
                int power = S1.Squareof();
                DecimalValue += dgt * power;


                num = num / 10;
                i += 1;
            }

            return DecimalValue;
        }


    }



}

