using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Palindrome
    {
        int num;
        public Palindrome(int number)
        {

            this.num = number;

        }

        public bool isPalindrome()
        {
            int originalNumber = this.num;
            string reverseStr = "";


            while (num != 0)
            {
                string lastdigitString = Convert.ToString(this.num % 10);

                reverseStr += lastdigitString;

                num = num / 10;
            }






     

            return originalNumber == Convert.ToInt32(reverseStr) ? true : false;





        }


    }
}
