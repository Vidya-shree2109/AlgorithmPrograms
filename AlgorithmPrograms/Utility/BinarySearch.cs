using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Utility
{
    public class BinarySearch
    {
        public void binarySearch(string[] inputArray, string key)
        {
            int start = 0;
            int end = inputArray.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (key == inputArray[mid])
                {
                    Console.WriteLine("The word is at the middle position {0}", mid);
                    break;
                }
                if (key.CompareTo(inputArray[mid]) > 0)
                {
                    start = mid - 1;
                    Console.WriteLine("The word is at position {0}", start);
                    break;
                }
                else
                {
                    end = mid + 1;
                    Console.WriteLine("The word is at position {0}", end);
                    break;
                }
            }
        }
    }
}
