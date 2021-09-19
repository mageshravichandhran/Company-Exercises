using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Repunit
    {
        public Repunit()
        {

        }

        public void Nrepunits(int num)
        {
            int i = 1;
            int count = 0;
            while (i>0 && count < num)
            {
                bool flag = true;
                int j;
                for (j=i; j != 0; j = j / 10)
                {
                    if (j % 10 != 1)
                    {
                        flag = false;
                        break;

                    }
                }
                if (flag)
                {
                    count += 1;
                    Console.WriteLine(i);
                }
                i += 1;
            }
        }
    }
}
