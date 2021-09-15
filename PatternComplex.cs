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
            int limit1, limit2;                                                                             //here we are setting a limit,basically the pattern is divide into two parts

            if (number % 2 != 0)
            {
                limit1 = number / 2 + 1;                                                                    //since odd nummbers wont give you a equal halves.so we are initiating one number bigger than another
                limit2 = number / 2;

                


            }
            else
            {
                limit1 = number / 2;                                                                        //if a number is even
                limit2 = limit1;

            }


            if (limit1 > 9)
            {
                limit1 = 9;                                                                                            // since we can include double digits in our pattern coz the allignment will not be correct
                limit2 = 9;
            }
            

           
           

            

            for (int i = 1; i <= limit1; i++)                                                                   // this is the 1st half of the pattern

            {
                for (int j = 1; j <= i; j++)                                                                         //the first half is divided into three parts each for loop is responsible for printing each parts

                {
                    Console.Write(j);                                                                                //for loop:1   will print you a  1 triangle with a increasing number order
                    Console.Write(" ");
                }

                for (int m =number; m > i + i; m--)                                                                     //it is responsible for printing a middle part of the first half,here the number of ele is in dec order and ele is in inc order
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                for (int s = i; s > 0; s--)                                                                 // it is responsible for printing the third and last part of the first half
                {
                    if (i == limit1 && s == limit1 && limit1!=limit2)                                           // the if will be triggered when there are unequal limits,in such occasions the top order will skip to print one iteration this will not affect our goal in any cases.
                                                                                                                        
                                                                                                                    //this line will print you a increasing number of numbers and decreasing numbers.
                    {
                        continue;
                    }

                    Console.Write(s);
                    Console.Write(" ");
                }
               
                Console.WriteLine();                                                                                
            }

            for (int k = limit2; k >= 1; k--)                                                                   //this section is for the bottom and last part it is also divided into three sections
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
       


    }
}

