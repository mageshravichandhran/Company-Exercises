using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
   

    class Powerseries
    {
        Square Squareval = new Square();
        public Powerseries()
        {

        }


        public int Sequence(int number,int powerlimit )
        {
            int result = 0;
            int count = 1;
            for(int i = 1; i <= powerlimit; i++)
            {
                if (i % 2 != 0)
                {
                    if (count % 2 == 0)
                    {
                        result = result - Squareval.Squareof(number, i);
                    }
                    else
                    {
                        result = result + Squareval.Squareof(number, i);

                    }
                   

                    count++;
                }


        
            }

            return result;
        }
    }
}
