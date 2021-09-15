using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class Repunit

    {
        int num;
        public Repunit(int num)
        {
            this.num = num;

        }


        public bool IsRepUnit()
        {
            bool isrep = true;





            while (this.num != 0)
            {
                int lstDigit = this.num % 10;

                if (lstDigit != 1)
                {
                    isrep = false;
                    break;
                }



                this.num = this.num / 10;
            }



            return isrep;






        }
    }
}
