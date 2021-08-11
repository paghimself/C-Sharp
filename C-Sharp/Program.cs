using Algorithms.Search;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var bs = new BinarySearcher<int>();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine(bs.FindIndex(arr, 2));
        }
    }
}
