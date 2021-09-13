using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Patterncomplex
    {
        public Patterncomplex()
        {

        }
        public void pattern1(int number)
        {
            int limit1, limit2;

            if (number % 2 != 0)
            {
                limit1 = number / 2 + 1;
                limit2 = number / 2;

                


            }
            else
            {
                limit1 = number / 2;
                limit2 = limit1;

            }


            if (limit1 > 9)
            {
                limit1 = 9;
                limit2 = 9;
            }
            

           
           

            

            for (int i = 1; i <= limit1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }

                for (int m =number; m > i + i; m--)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                for (int s = i; s > 0; s--)
                {
                    if (i == limit1 && s == limit1 && limit1!=limit2)
                    {
                        continue;
                    }

                    Console.Write(s);
                    Console.Write(" ");
                }
               
                Console.WriteLine();
            }

            for (int k = limit2; k >= 1; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    Console.Write(l);
                    Console.Write(" ");

                }
                for (int n = k; n < number - k; n++)
                {
                    Console.Write(k);
                    Console.Write(" ");

                }

                for (int p = k; p >= 1; p--)
                {
                    Console.Write(p);
                    Console.Write(" ");
                }



                Console.WriteLine();
            }
        }
        public void pattern2(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j >= 0; j--)
                {

                    Console.Write("   ");

                }
                Console.Write("*");


                for (int j = 10; j > i; j--)
                {
                    Console.Write("  ");
                }
                Console.Write("*");


                Console.WriteLine(" ");



                Console.WriteLine();
           

            }
           
                
            

        }


    }
}

