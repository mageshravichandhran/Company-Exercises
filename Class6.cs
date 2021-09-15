using System;
using System.Collections.Generic;
using System.Text;

namespace Set3
{
    class Pattern
    {
        int num;
        public Pattern(int num)
        {
            this.num = num;



        }

        public void PrintPyramid1()
        {
            for (int i = 0; i < this.num; i++)
            {
                for (int j = this.num + 2; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        public void printpattern2()
        {
            for (int i = 1; i < this.num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

        }


        public void printpattern3()
        {

            for (int i = 1; i < this.num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

        }



    }
}
