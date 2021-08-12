using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int num = 7;

            // IndexOf(T[] array, T charlie, int startIndex, int arrayLength)
            bool z = Array.IndexOf(arr, num, 0, arr.Length) > -1;
            Console.WriteLine(z);
        }
    }
}
