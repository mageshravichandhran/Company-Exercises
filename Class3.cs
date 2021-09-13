using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Patterncomplex
    {
        public Patterncomplex()
        {

        }
        public void pattern1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }

                for (int m = 8; m >= i + i; m--)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                for (int s = i; s > 0; s--)
                {
                    if (i == 5 && s == 5)
                    {
                        continue;
                    }
                    Console.Write(s);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            for (int k = 4; k >= 1; k--)
            {
                for(int l = 1; l <= k; l++)
                {
                    Console.Write(l);
                    Console.Write(" ");

                }
                for(int n=k;n<9-k;n++)
                {
                    Console.Write(k);
                    Console.Write(" ");

                }

                for(int p = k; p >= 1; p--)
                {
                    Console.Write(p);
                    Console.Write(" ");
                }



                Console.WriteLine();
            }
        }


    }
}
