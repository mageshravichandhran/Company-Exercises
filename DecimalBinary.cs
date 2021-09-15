using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class DecimalBinary
    {
        int num;
         public DecimalBinary(int number)
        {
            this.num=number;
        }
        public int ToDecimal()
        {
            
            int DecimalValue = 0;
            int i= 0;
            
            while (this.num != 0)

            {


                int dgt = this.num % 10;
                Square S1 = new Square(2, i);
                int power = S1.Squareof();
                DecimalValue += dgt * power;


                this.num = this.num / 10;
                i += 1;
            }
           
            return DecimalValue;
        }
        public int Tobinary()
        {
            string numberStr = "";
            string finalStr = "";
            while (this.num > 0) 
            {
                numberStr += Convert.ToString(this.num % 2);

                this.num = this.num / 2;
            }
            int result = Convert.ToInt32(numberStr);

            while (result != 0)
            {
                int lastDigit = result % 10;
                finalStr += Convert.ToString(lastDigit);
                result = result / 10;
            }
            return Convert.ToInt32(finalStr);
        }
    }
}
