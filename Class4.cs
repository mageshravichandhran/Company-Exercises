using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class String1
    { string str;
        char character;
        public String1(string str,char character)
        {
            this.str = str;
            this.character = character;
        }

        public int Count1()
        {
            int count = 0;
            for (int i = 0; i <= this.str.Length - 1; i++) 
            {
                if (this.character == this.str[i])
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
