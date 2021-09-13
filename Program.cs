using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Pattern P1 = new Pattern(20);
            //P1.pattern1();

            //Counters C1 = new Counters("34354445454");
            //C1.count();

            //Patterncomplex P = new Patterncomplex();
            //P.pattern1();

            //String1 S1 = new String1("malayalam", 'a');
            //Console.WriteLine(S1.Count1());

            //Sentence S = new Sentence("Hello Everyone Im Magesh");
            //Console.WriteLine(S.Counter());

            Sentence S2 = new Sentence("Hey Im Magesh Ravichandran From Chennai");
            Console.WriteLine(S2.ShortWord());

        }
    }
}
