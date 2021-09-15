using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class StudentTable
    {
        string[] name;
        int[] age;
        int[] marks;
        public StudentTable(string[] name, int[] age, int[] marks)
        {
            this.age = age;
            this.name = name;
            this.marks = marks;
        }

        public void DisplayTable()

        {

            int nooffields = 3;
            int onetab = 4;
            int spacecalc = onetab * (nooffields - 1);
            string header = "NAME\tAGE\tMARKS";
            Console.WriteLine("NAME\tAGE\tMARKS");
            for (int j = 0; j < header.Length+spacecalc; j++)
            {
                Console.Write("_");
                if (j == header.Length+spacecalc-1)
                {
                    Console.Write("_\n");
                }
            }
            for (int i = 0; i < this.name.Length; i++)
            {

                
                Console.WriteLine("{0}\t{1}\t{2}\t",this.name[i],this.age[i],this.marks[i]);
                for (int j = 0; j < header.Length+spacecalc; j++)
                {
                    Console.Write ("_");
                }
                Console.WriteLine();
            }


        }



    }
}
