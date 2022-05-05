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
        Console.WriteLine("1.Binary Search\n2.Insertion Sort\n3.Exit");
        while (check)
        {
            Console.Write("\nEnter an option to execute :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binary = new BinarySearch();
                    string[] inputArray = File.ReadAllLines(path);
                    Console.WriteLine("Enter a word to search :");
                    string word = Console.ReadLine();
                    binary.binarySearch(inputArray, word);
                    break;
                case 2:
                    InsertionSort sort = new InsertionSort();
                    sort.Sort();
                    break;
                case 3:
                    check = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option !");
                    break;
            }
        }
    }
}