using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
   class Atmorphic
    {
        int num;
        public Atmorphic(int number)
        {
            this.num = number;
        }

        public bool isAtmorphic()
        {
            return this.num * this.num % 10 == this.num % 10;
            
        }
    }



    
}
