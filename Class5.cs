using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Sentence
    {
        string str;
        public Sentence(string str)
        {
            this.str = str;
        }

        public int Counter()
        {
            int count = 1;
            for(int i = 0; i < this.str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    count += 1;
                }
            }

            return count;
        }

        public bool ShortWord()
        {
            int num = this.Counter();


            int[] counter = new int[num];
            int count = 0;
            int j = 0;
            for(int i = 0; i <=this.str.Length - 1; i++)
            {
               
                if (this.str[i]==' ' || i==this.str.Length-1)
                {

                    counter[j] = count;
                    count = 0;
                    j += 1;
                    

                }
                count += 1;

            }
            foreach(int ele in counter)
            {
                Console.WriteLine(ele);
            }

            return true;
            

        }







    }
}
