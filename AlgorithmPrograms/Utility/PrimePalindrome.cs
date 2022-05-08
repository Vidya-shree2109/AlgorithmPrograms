using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Utility
{
    public class PrimePalindrome
    {
        public void PrimePalindromNumber()
        {
            int count = 0;
            Console.WriteLine("Enter the range : ");
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe prime palindrome numbers are : ");
            for (int i = first; i <= end; i++)
            {
                int num = i, reverseNum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    reverseNum = reverseNum * 10 + digit;
                }
                if (reverseNum == i)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write(i + " ");
                        count++;
                        if (count == 10)
                        {
                            count = 0;
                        }
                    }
                }
            }
        }
    }
}
