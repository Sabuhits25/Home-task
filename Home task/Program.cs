﻿namespace Home_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region arrayin tersine cevrilmesi
            //int[] numbers = { 1, 2, 43, 567, 23, 21 };
            //int i = 0;
            //int third = 0;

            //for (i = 0; i < numbers.Length / 2; i++)
            //{
            //    third = numbers[i];

            //    numbers[i] = numbers[numbers.Length - i - 1];
            //    numbers[numbers.Length - i - 1] = third;
            //}
            //for (i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region oxsar reqemin bildirilmesi
            //int[] numbers = { 1, 2, 43, 567, 23, 23 };
            //int i = 0;
            //for (i = 0; i < numbers.Length - 1; i++) 
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        Console.WriteLine($"Oxsar reqem var {numbers[i]}");
            //    }
            //}
            #endregion


            #region task 2
            int[] numbers = { 3, 5, 7, 9, 24, 24 };
            int[] numbers2 = { 3, 5, 7, 9, 24, 24 };
            int i = 0;
            int i2= 0;
            bool copy=true;

            if(numbers.Length > numbers2.Length)
            {
                copy = false;
            }
            else
            {
                for(i=0; i<numbers.Length; i++)
                {
                    bool found=false;
                    for (i2 = 0; i2 < numbers2.Length; i2++)
                    {
                        if (numbers2[i2] == numbers[i])
                        {
                            found=true;
                            break;  
                        }

                    }

                    if (found)
                    {
                        copy = false;
                        break;
                    }
                }
            }
            #endregion







        }



    }
}
