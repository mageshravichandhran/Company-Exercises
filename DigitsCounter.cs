using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class DigitsCounter
    {
        int num;
        public DigitsCounter(int number)
        {
            this.num = number;
        }
        public int NumberofDigits()
        {
            int count = 0;
            while (this.num != 0)
            {
                this.num =this.num / 10;
                count += 1;

            }
            return count;
        }

    }
}
