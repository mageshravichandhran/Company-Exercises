using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
   public class Armstrong
    {
		int num;
		public Armstrong(int number)
		{


			this.num = number;



		}

		public  bool isArmstrong()
		{
			int finalSum = 0;
			while (this.num != 0)
			{
				int lastnum = this.num % 10;
				int cubenumber = lastnum * lastnum * lastnum;
				finalSum += cubenumber;

				this.num = this.num / 10;


			}


			bool isSame = finalSum == this.num ? true : false;


			return isSame;

		}




	}
}
