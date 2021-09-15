using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
   public class ArithmeticOperations
    {
        int a;
        int b;

        public ArithmeticOperations(int a,int b)
        {

            this.a = a;
            this.b = b;
        }

        public int add()
        {
            return this.a + this.b;
        }

        public int dif()

        {


            return this.a - this.b;

        }


        public int mul()
        {
            return this.a * this.b;
        }


        public int div()
        {
            return this.a / this.b;
        }

        public int mod()
        {
            return this.a % this.b;
        }





    }
}
