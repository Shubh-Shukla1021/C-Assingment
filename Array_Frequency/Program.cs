using System;

namespace Array_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8,1,1,3,8,4,5,2,3,2 };
           
            int[] arr1 = new int[arr.Length];
            int exist = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        
                        arr1[j] = exist;
                    }
                }
                if (arr1[i] != exist)
                    arr1[i] = count;
            }

            
            Console.WriteLine(" Element Frequency is");
            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != exist)
                    Console.WriteLine(arr[i] + "   frequency is   " + arr1[i]);
            }
            
            Console.ReadLine();
        }
    }
}
