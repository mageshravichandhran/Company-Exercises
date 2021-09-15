using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class MultiplicationTable
    {
        int num, limit;
        public MultiplicationTable(int num,int limit)
        {
            this.num = num;
            this.limit = limit;
        }


        public void Tables()
        {
            for (int i = 1; this.limit   + 1 > i; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", this.num, i, this.num * i);
            }
        }
    }
}
