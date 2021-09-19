using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class DoubleLetterSequence
    {
        public DoubleLetterSequence()
        {

        }
        public int CountDoubleLetters(string str)
        {
            int count = 0;
            for(int i = 1; i < str.Length-2; i++)
            {
                if (str[i] == str[i + 1] && str[i] != str[i + 2] && str[i-1]!=str[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
