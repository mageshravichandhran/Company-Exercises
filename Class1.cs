using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Square
    {
        
        public Square()
        {
           
        }

        public int Squareof(int num1,int num2)
        {
            int squareVal = 1;
            while (num2 != 0)
            {
                squareVal *= num1;
                num2 -= 1;
            }

            return squareVal;
        }



    }
}
