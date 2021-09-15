using System;

namespace Set1
{
    class Program1
    {

        static void Main(string[] args)                                                                                                                 //solutions for problems given on 

        {


            Console.WriteLine(args[0]);


            //int[] arr = { 1, 2, 3, 12, 45, 32, 10 };
            /*Sorting(arr);
            foreach(int ele in arr)
            {
                Console.Write(ele + " ");
            }*/






            int a = 10, b = 5;
            Console.WriteLine("The sum is : {0}", add(a, b));
            Console.WriteLine("The difference is :{0}", dif(a, b));

            //Console.WriteLine("The Product is :{0}",mul(a, b));                                        //Driver Code for Program 1
            //Console.WriteLine(" The Division is :{0}",div(a, b));
            //Console.WriteLine("The Remainder is :{0}",mod(a, b));
            //int number = 13;
            //EvnOdd(number);


            //int celcius = 24;
            //int farhen = 75;
            //Console.WriteLine(Tofarhenhit(celcius));                                                 // Driver Code for program 4
            //Console.WriteLine(ToCelcius(farhen));



            //int principle = 10000;
            //int Roi = 18;
            //int yrs = 3;                                                                             // Driver Code for Program 6
            //int SimpleIntrest = Interest(principle, Roi, yrs);
            //Console.WriteLine(SimpleIntrest);


            //TablesSeven(10);                                                                         // Driver code for Program 1 in Loops


            Tables(43, 100);                                                                         // tried it for all Tables




            //CheckPrime(7);                                                                            // driver code -program 2 -loops



            //Console.WriteLine(Primorial(10));                                                         //driver code for program 3 in Loops

            //factorsN(20);                                                                             // driver code for program 7 in loops                                       

            //int FactorSum = factorSum(20);                                                            // driver code for program 9 in loops
            //Console.WriteLine(FactorSum);

            //int NoFactors = N_factors(20);                                                             //  driver code for program 8 in loops
            //Console.WriteLine(NoFactors);                                                         

            ProperFactors(20);                                                                           //driver code for program 10 in loops


            //Console.WriteLine(isamicable(10, 10));                                                       // driver code for program -11-loops

            Console.WriteLine(SumProperFact(20));


            // numtype(30);                                                                          //driver code for program -11-loops




            //Console.WriteLine(Calculator());                                                         // driver code for program -5 in basics

            //Console.WriteLine(IsRepUnit(1111111));                                                   // driver code for rep unit program






            Console.ReadLine();
        }

        static int[] Sorting(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            return arr;
        }

        //Program: 1, Arithmetic Operations
        static int add(int a, int b)
        {
            return a + b;
        }

        static int dif(int a, int b)

        {
            int res = (a - b);

            return res;

        }


        static int mul(int a, int b)
        {
            return a * b;
        }


        static int div(int a, int b)
        {
            return a / b;
        }

        static int mod(int a, int b)
        {
            return a % b;
        }


        //program:2 Finding Even or odd number

        static void EvnOdd(int num)
        {
            string res = num % 2 == 0 ? "The Given Number is Even" : "The Given Number is Odd";

            Console.WriteLine(res);
        }

        //program 3: converting Celcius to Farhenhit and vice versa

        static int Tofarhenhit(int cel)
        {

            int farhen = ((cel * 9) / 5) + 32;
            return farhen;

        }

        static int ToCelcius(int farhen)
        {
            int cel = (farhen - 32) * 5 / 9;
            return cel;
        }


        // program 4: calculating Simple interest
        static int Interest(int principle, int roi, int yrs)
        {
            int si = (principle * yrs * roi) / 100;
            return si;


        }

        //loops
        //program 5: Multiplications table of 7;

        static void TablesSeven(int num)
        {
            for (int i = 1; num + 1 > i; i++)
            {
                Console.WriteLine("7 x {0} = {1}", i, 7 * i);
            }

        }

        //program 6 :Multiplication  table of any number

        static void Tables(int num, int limit)
        {
            for (int i = 1; limit + 1 > i; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            }
        }

        //program 7 : check Prime Number or Composite number


        static bool CheckPrime(int n)
        {


            bool is_prime = false;
            for (int i = 2; i < n; i++)
            {


                if (n % i == 0)
                {

                    is_prime = true;

                    break;
                }

            }

            if (is_prime)
            {
                //Console.WriteLine("The Given number is a composite number");
                return true;
            }
            else
            {
                //Console.WriteLine("The Given number is a prime number");
                return false;


            }
        }
        // program 8 Primorial

        static int Primorial(int n)
        {
            int mulval = 1;
            for (int i = 2; i <= n; i++)
            {
                if (!CheckPrime(i))
                {
                    Console.WriteLine(i);
                    mulval *= i;
                }

            }
            return mulval;
        }

        // program 9 program to find factors of n

        static void factorsN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        //program 10 program to find sum of factors of n

        static int factorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }


        //program 11 program to find number of factors;

        static int N_factors(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count += 1;
                }
            }

            return count;
        }

        // program 12 program to find proper factors


        static void ProperFactors(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // program 13 program to find amicable;

        static int SumProperFact(int n)

        {
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static bool isamicable(int num1, int num2)

        {
            return SumProperFact(num1) == SumProperFact(num2) ? true : false;
        }

        //program 14 

        static void numtype(int num)
        {
            int sum_num = factorSum(num);

            if (sum_num < num * 2)
            {
                Console.WriteLine("deficient");
            }

            else if (sum_num > num * 2)
            {
                Console.WriteLine("abudant");
            }

            else if (sum_num == num)
            {

                Console.WriteLine("perfect");
            }

        }

        // program 15 A Basic Calculator

        static float Calculator()
        {
            Console.WriteLine("Please the enter the Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please the enter the Number 2: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the operator");


            float result;

            string opert = Console.ReadLine();

            switch (opert)

            {

                case "+":
                    result = num1 + num2;
                    break;



                case "-":
                    result = num1 - num2;
                    break;

                case "*":

                    result = num1 * num2;
                    break;
                case "/":

                    result = num1 / num2;
                    break;

                case "%":
                    result = num1 % num2;
                    break;


                default:

                    result = 0;
                    break;
            }


            return result;


        }

        // program 16   ToCheck Number is a Rep unit or not



        static bool IsRepUnit(int num)
        {
            bool isrep = true;





            while (num != 0)
            {
                int lstDigit = num % 10;

                if (lstDigit != 1)
                {
                    isrep = false;
                    break;
                }



                num = num / 10;
            }



            return isrep;






        }






    }



















}
