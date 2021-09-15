using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Evenodd
    {

        int num;
        public Evenodd(int num)
        {
            this.num = num;
        }
        public void EvnOdd()
        {
            string res = this.num % 2 == 0 ? "The Given Number is Even" : "The Given Number is Odd";

            Console.WriteLine(res);
        }
    }
}
