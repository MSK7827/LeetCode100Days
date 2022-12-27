using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode100Days
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            var arra = new int[] { 1, 2, 3, 4, 5, 6,10,12,4,5,5,56,6,6 };
            int num = 9;
            Search(arra, num);
        }
        public static void Search(int[] arr , int num) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) { Console.WriteLine(arr[i]); break; }    
            }

        }

        public static void InsertIntoEndUnsortedArray(int[] arr , int num)
        {

        }
    }
}
