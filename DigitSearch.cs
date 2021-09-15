using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class DigitSearch
    {
        int num;
        int search;
        public DigitSearch(int number,int search)
        {
            this.num = number;
            this.search = search;

        }
        public void Count()
        {
            int originalnum = this.num;

            int count = 0;
            while (this.num != 0){

                int lstdgt = num % 10;

                if (lstdgt == this.search)
                {

                    count += 1;


                }
                this.num = this.num / 10;
            }
            Console.WriteLine("The Number of Occurances of {0} in {1} is {2} ", this.search,originalnum, count);

        }

        
    }
}
