using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
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
            for (int i = 0; i < this.str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    count += 1;
                }
            }

            return count;
        }

        public string ShortWord()
        {
            int num = this.Counter();
            string[] strarr = this.str.Split();

            int[] counter = new int[num];
            int count = 0;
            int j = 0;
            for (int i = 0; i <= this.str.Length-1 ; i++)
            {

                if (this.str[i] == ' ' || i == this.str.Length - 1)
                {

                    counter[j] = count;
                    count = 0;
                    j += 1;


                }
                if (i == 0)
                {
                    count += 1;
                }
                count += 1;
            }



         int[] newcounter = (int[]) counter.Clone();

            Array.Sort(newcounter);
            int min = newcounter[0];

            int idx = Array.IndexOf(counter, min);
            





            return strarr[idx];

        }

        public string LongWord()
        {
            int num = this.Counter();
            string[] strarr = this.str.Split();

            int[] counter = new int[num];
            int count = 0;
            int j = 0;
            for (int i = 0; i <= this.str.Length - 1; i++)
            {

                if (this.str[i] == ' ' || i == this.str.Length - 1)
                {

                    counter[j] = count;
                    count = 0;
                    j += 1;


                }
                if (i == 0)
                {
                    count += 1;
                }
                count += 1;
            }



            int[] newcounter = (int[])counter.Clone();

            Array.Sort(newcounter);
            int max = newcounter[newcounter.Length-1];

            int idx = Array.IndexOf(counter, max);






            return strarr[idx];




        }







    }
}


