using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Counters
    {
        string str;
        public Counters(string str)
        {
            this.str = str;
        }

        public void count()
        {
          
            for(int i = 0; i < this.str.Length; i++)
            {
                int count = 0;
                for(int j =0; j <this.str.Length; j++)
                {
                    if (str[i] == str[j])
                    {

                        count += 1;
                      
                      

                    }

                   
                 

                }
                Console.WriteLine("The count of {0} is {1}", str[i], count);
            }
        }



    }
}
