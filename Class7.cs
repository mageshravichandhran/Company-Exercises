using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class CurrentBillCalc
    {

        public CurrentBillCalc()
        {

        }
        public int billcalc(int units)
        {
            if (units <= 100)
            {
                return 0;
            }
            else if (units <= 200)
            {
                return (units - 100) * 2;
            }
           else if (units <= 300 && units>=200)
            {
                return ((100*0)+ (100 * 2) + ((units-200) * 3));
            }
            else if(units<=400 && units >= 300)
            {
                return ((100 * 0) + (100 * 2) + (100 * 3) + (( units-300) * 4));
            }
            else if(units<=600 && units >= 400)
            {
                return ((100 * 0) + (100 * 2) + (100 * 3) + (100 * 4) + (( units-400) * 6));

            }
            else
            {
                return ((100 * 0) + (100 * 2) + (100 * 3) + (100 * 4) + (200 * 6) + ((units - 600) * 7));
            }


        }
    }
}
