using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Utility
{
    public class PrimeNumber
    {
        int primeCount = 0;
        public void IsPrime(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    primeCount++;
                    Console.WriteLine(i + " is Prime\n");
                }
                else
                {
                    Console.WriteLine(i + " is Not Prime\n");
                }
            }
            Console.WriteLine("Total number of prime numbers present in the given range -> " + primeCount);
        }
    }
}
