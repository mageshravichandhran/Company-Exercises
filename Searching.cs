using System;
using System.Collections.Generic;
using System.Text;


namespace Set2
{
    class Searching
    {
        int[] arr;
        int num;
        public Searching(int[] arr,int num)
        {
            this.arr = arr;
            this.num = num;
        }

        public int linearsearch()
        {
            for (int k = 0; k <= this.arr.Length - 1;k++) 
            {
                if (this.num == this.arr[k])
                {
                    return k;
                }
       
            }
            return -1;
            
        }
            


    }
}
