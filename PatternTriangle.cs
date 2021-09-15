using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class PatternTriangle
    {
        int num;
        public PatternTriangle(int number)
        {
            this.num = number;
        }


        public void pattern1()
        {
            for (int i = 0; i < this.num; i++)
            {
                for (int j = this.num; j >= i; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }


}


