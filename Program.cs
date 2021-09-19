using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Powerseries powser = new Powerseries();
            //Console.WriteLine(powser.Sequence(2, 6));

            //Repunit repunit = new Repunit();
            //repunit.Nrepunits(10);
            //

            //LCMGCD number = new LCMGCD();
            //Console.WriteLine (number.Lcm(96,77));
            //Console.WriteLine(number.Gcd(45,5));
            //Console.ReadLine();

            //DoubleLetterSequence Countletters = new DoubleLetterSequence();
            //Console.WriteLine(Countletters.CountDoubleLetters("EffivityTechnologies"));
            //Console.ReadLine();


            Incometax tax = new Incometax();
            Console.WriteLine(tax.CalculateTax(16000));
            Console.ReadLine();




        }
    }
}
