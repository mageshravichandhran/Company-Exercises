using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Square
    {
        int num1;
        int num2;
        public Square(int number1,int number2)
        {
            this.num1 = number1;
            this.num2 = number2;
        }

        public int Squareof()
        {
            int squareVal = 1;
            while (this.num2 != 0)
            {
                squareVal*= this.num1;
                this.num2 -= 1;
            }

            return squareVal;
        }



    }
}
