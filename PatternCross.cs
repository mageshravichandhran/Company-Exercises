using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Patterncross
    {
        int num;
        public Patterncross(int num)
        {
            this.num = num;

        }

        public void displaypattern()
        {


            

            for(int i = 0; i< this.num; i++)
            {

                for(int j = 0; j <= this.num; j++)
                {
                    if (i == j)                                           //this line will print from top left to bottom right, (diagonaly)
                    {
                        Console.Write("X");
                      
                    }
                    else if ((i==0+i) && (j==this.num-i))
                    {
                        Console.Write("X");                                    // this line will print from top right to bottom left (diagonally)

                                                                                   // the row is incremented and column is decremented so we are using iterator i which basically  increments by 1..using i we are incrementing the row and decrementing the column by 1.

                    }

                    else
                    {
                        Console.Write(" ");                                         // this line will print the remaining empty spaces
                    }
                }

                Console.WriteLine("");


            }




        }


    }
}
