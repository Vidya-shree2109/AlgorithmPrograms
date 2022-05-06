using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Utility
{
    public class Anagram
    {
        int count = 0;
        public void IsAnagram(string firstWord, string secondWord)
        {
            int firstLength = firstWord.Length;
            int secondLength = secondWord.Length;

            bool status = true;
            if (firstLength != secondLength)
            {
                status = false;
            }
            else
            {
                char[] firstArray = firstWord.ToLower().ToCharArray();
                char[] secondArray = secondWord.ToLower().ToCharArray();
                Array.Sort(firstArray);
                Array.Sort(secondArray);
                status = secondArray.Equals(firstArray);

                for (int i = 0; i < firstLength && firstLength == secondLength; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "word is Anagram");
            }
            else
            {
                Console.WriteLine(firstWord + " " + "and" + " " + secondWord + " " + "word is not Anagram");
            }

        }

    }
}
