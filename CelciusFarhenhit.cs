using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class CelciusFarhenhit
    {
        int num;

        public CelciusFarhenhit(int num)
        {
            this.num = num;
        }


       public int Tofarhenhit()
        {


            return ((this.num * 9) / 5) + 32;

        }

        public int ToCelcius()
        {
            
            return (this.num - 32) * 5 / 9;
        }
    }
}
