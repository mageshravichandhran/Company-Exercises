using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class Sorting
    {
        int[] arr;


        public Sorting(int[] arr)
        {
            this.arr = arr;
        }

        public int[] BubbleSort(int num)
        {
            if (num > 0)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[i] >= arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;

                        }
                    }
                }




            }

            else
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
            }

            return arr;
            

        }
        public int[] selectionsort(int num)
        {
            if (num > 0)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[min] >= arr[j])
                        {
                            min = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;



                }
                
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[min] <= arr[j])
                        {
                            min = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;



                }
               
            }

            return arr;


        }


    }
}
