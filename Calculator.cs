using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
   public class Calculator
    {

        public Calculator()
        {

        }

        static float Calc()
        {
            Console.WriteLine("Please the enter the Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please the enter the Number 2: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the operator");


            float result;

            string opert = Console.ReadLine();

            switch (opert)

            {

                case "+":
                    result = num1 + num2;
                    break;



                case "-":
                    result = num1 - num2;
                    break;

                case "*":

                    result = num1 * num2;
                    break;
                case "/":

                    result = num1 / num2;
                    break;

                case "%":
                    result = num1 % num2;
                    break;


                default:

                    result = 0;
                    break;
            }


            return result;


        }
    }
}
