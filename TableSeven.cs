using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Tableseven
    {
        int limit;
        public Tableseven(int limit)
        {
            this.limit = limit;
        }
       public void TablesSeven()
        {
            for (int i = 1; this.limit + 1 > i; i++)
            {
                Console.WriteLine("7 x {0} = {1}", i, 7 * i);
            }

        }

    }
}
