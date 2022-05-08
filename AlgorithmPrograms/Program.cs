using System;
using AlgorithmPrograms;
using AlgorithmPrograms.Utility;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("                                   WELCOME TO ALGORITHM PROGRAMS                                   ");
        bool check = true;
        const string path = @"E:\PracticeProblems\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\Utility\BinarySearchFile.txt";
        Console.WriteLine("1.Binary Search\n2.Insertion Sort\n3.Bubble Sort\n4.Check For Anagram\n5.Prime Number In Range\n6.Prime Palindrome\n7.Exit");
        while (check)
        {
            Console.Write("\nEnter an option to execute :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binary = new BinarySearch();
                    string words = File.ReadAllText(path);
                    string[] inputArray = words.Split(',');
                    Console.WriteLine("Enter a word to search :");
                    string word = Console.ReadLine();
                    binary.binarySearch(inputArray, word);
                    break;
                case 2:
                    InsertionSort sort = new InsertionSort();
                    sort.Sort();
                    break;
                case 3:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Sort();
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    string firstWord = "TheClassroom";
                    string secondWord = "SchoolMaster";
                    anagram.IsAnagram(firstWord, secondWord);
                    break;
                case 5:
                    PrimeNumber prime = new PrimeNumber();
                    Console.WriteLine("Enter the Range of the Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    prime.IsPrime(firstNumber, secondNumber);
                    break;
                case 6:
                    PrimePalindrome primePalindrome = new PrimePalindrome();
                    primePalindrome.PrimePalindromNumber();
                    break;
                case 7:
                    check = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option !");
                    break;
            }
        }
    }
}