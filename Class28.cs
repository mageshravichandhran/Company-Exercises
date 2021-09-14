using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class CurrentBill
    {
        int units;
        static int stage1=2;
        static int stage2=6;
        static int stage3=8;

      
        public CurrentBill(int units)
        {
            this.units = units;
        }

        public int BillCalc()
        {
           

            if (this.units < 100)
            {
               return 0;
            }

            else if(this.units>=100 && this.units <= 200)
            {
                return this.units * stage1;
            }

            else if(this.units>=200 && this.units <= 400)
            {
                return this.units * stage2;
            }

            else
            {
                return this.units * stage3;
            }

       

        }

    }
    
}
