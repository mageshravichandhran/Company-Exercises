using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Buzz
    {
        int num;
        public Buzz(int number)
        {
            this.num = number;
        }


        public void buzzNumbers()
        {
            int i = 1;
            int count = 0;
            while (count<=this.num && i>0)
            {

                if(i%10==7 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                    count += 1;
                }
                i += 1;
            }
        }
    }
}
