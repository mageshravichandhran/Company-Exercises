using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Extract
    {
        int num;
        public Extract(int number)
        {
            this.num = number;
        }


        public void ExtractDigits()
        {

            Console.WriteLine("Please enter \"sum\" or \"square\" or \"cube\" ");
            string operation = Console.ReadLine();

            float sum_result = 0;
            int mul_result = 1;
            int cube_result = 1;
            string reverseStringNumber = "";



            while (this.num != 0)
            {

                int lastnumber = this.num % 10;

                reverseStringNumber += Convert.ToString(lastnumber);

                this.num = this.num / 10;


            }



            num = Convert.ToInt32(reverseStringNumber);
            while (this.num != 0)
            {
                int lst_digit = this.num % 10;
                switch (operation)
                {
                    case "sum":
                        sum_result += lst_digit;
                        break;
                        
                        
                        
                        
                    case "square":
                        mul_result = lst_digit * lst_digit;
                        Console.WriteLine(mul_result);

                        break;

                    case "cube":

                        cube_result = lst_digit * lst_digit * lst_digit;
                        Console.WriteLine(cube_result);
                        break;

                }
                

                num = this.num / 10;





            }
            if (operation == "sum")
            {
                Console.WriteLine(sum_result);
            }








        }






    }
}
