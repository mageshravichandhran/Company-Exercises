using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Anagrams
    {
        string str1;
        string str2;

        public Anagrams(string str1,string str2)
        {
            this.str1 = str1;
            this.str2 = str2;

        }
        public bool IsAnagram()
        {
            bool check1 = this.str1.Length == this.str2.Length ? true : false;


            bool isanagram = false;

            if (check1){

                for (int i = 0; i < this.str1.Length; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < this.str2.Length; j++)
                    {
                        if (this.str1[i] == this.str2[j])
                        {
                            flag = true;
                            break;
                            
                           
                          
                        }
                    }

                    if (flag==false)
                    {
                        isanagram = false;
                        break;
                        
                    }

                    isanagram = true;

                }
                for (int i = 0; i < this.str1.Length; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < this.str2.Length; j++)
                    {
                        if (this.str1[i] == this.str2[j])
                        {
                            flag = true;
                            break;



                        }




                    }

                    if (flag == false)
                    {
                        isanagram = false;
                        break;

                    }

                    isanagram = true;

                }


            }
            return isanagram;


        }


    }
}
