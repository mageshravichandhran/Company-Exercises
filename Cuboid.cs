using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Cuboid
    {
        int length;
        int breadth;
        int height;
        public Cuboid(int length,int breadth,int height)
        {

            this.length = length;
            this.breadth = breadth;
            this.height = height;

        }


        public int CalcVolume()
        {


            return this.length * this.breadth * this.height;

        }


        public int diagnol()
        {
            return (int)  Math.Sqrt(this.length * this.length + this.height * this.height + this.breadth * this.breadth);
        }


        public int SurfaceArea()
        {
            return ((this.length * this.breadth) + (this.breadth * this.height) + (this.length * this.height));
        }

    }
}
