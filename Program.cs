using System;
using System.Collections.Generic;

namespace MinimumAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = minimumAbsoluteDifference(arr);

            Console.WriteLine(result);
        }

        private static int minimumAbsoluteDifference(int[] arr)
        {
            int minDif = int.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                int dif = Math.Abs(arr[i] - arr[i + 1]);
                minDif = Math.Min(dif, minDif);

            }
            return minDif;
        }

        //this is O(n^2) solution. there is better performanced way to do this. check out above 
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    List<int> myList = new List<int>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        myList.Add(int.Parse(Console.ReadLine()));
        //    }

        //    int result = minimumAbsoluteDifference(myList);
        //}

        //private static int minimumAbsoluteDifference(List<int> myList)
        //{
        //    int minDif = int.MaxValue;
        //    for (int i = 0; i < myList.Count-1; i++)
        //    {
        //        for (int j = i+1; j <= myList.Count-1; j++)
        //        {
        //            int dif = Math.Abs(myList[i] - myList[j]);
        //            if (dif < minDif)
        //            {
        //                minDif = dif;
        //            }

        //        }
        //    }

        //    return minDif;
        //}
    }
}
