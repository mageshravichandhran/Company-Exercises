using System;
using System.Collections.Generic;
using System.Text;

namespace Set3
{
    class Player

    {
        string name;
        int age;
        public int runs;
        public int totalruns;


        public Player(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.runs = 0;
        }
        public void play()
        {
            Random R = new Random();
            for (int i = 0; i <= 6; i++)
            {
                this.runs += R.Next(6);



            }
        }

        public void display()
        {
            Console.WriteLine("Batsman Name : {0}", this.name);
            Console.WriteLine("Batsman Age:{0}", this.age);

            Console.WriteLine("Batsman runs:{0}", this.runs);



        }
    }
}
