using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    internal class Program
    {

        static int BinarySearch(int[] arr, int n, int s)
        {
            int left = 0;
            int right = n - 1;
            int mid;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (arr[mid]==s)
                {
                    return mid;
                }
                if (arr[mid] > s)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] searchingOn = { 2, 5, 6, 8, 23, 54, 85};
            int n = searchingOn.Length;
            int result = BinarySearch(searchingOn, n, 23) ;
            Console.WriteLine("Result found on index " + result);
        }
    }
}
