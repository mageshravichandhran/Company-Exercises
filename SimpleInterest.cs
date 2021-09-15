using System;
using System.Collections.Generic;
using System.Text;

namespace Set1
{
    public class SimpleInterest
    {
        int p, n, r;
        public SimpleInterest(int p,int n,int r)
        {
            this.p = p;
            this.n = n;
            this.r = r;

        }

       public int Interest()
        {
        
            return (this.p * this.n * this.r) / 100;


        }
    }
}
