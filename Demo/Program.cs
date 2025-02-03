using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using static Assignment.ListGenerators;
using System.Collections;
using System.Text.RegularExpressions;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Partitioning Operators
            #region Q1 - Get the first 3 orders from customers in Washington
            //var Result = CustomerList.Where(C=> C.City == "Washington").Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2 - Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList.Where(C => C.City == "Washington").Skip(2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3- Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.Where((n, i) => n < i).Skip(6);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4- Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.Where(n => n % 3 == 0).Take(4);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5- Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.Where((n, i) => n < i).Take(6);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Q1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var Words = File.ReadAllLines("dictionary_english.txt").Contains("ei");
            //Console.WriteLine(Words);
            #endregion

            #region Q2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.Where(p => p.UnitsInStock == 0).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"*{item.Key}*");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"==>> {item1}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"*{item.Key}*");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine($"==>{item1}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion

            #region LINQ – Grouping Operators
            #region Q1- Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Remainder By {item.Key}");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q2- Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //List<string> words = File.ReadAllLines("dictionary_english.txt").ToList();
            //var Results = words.GroupBy(W => W[0]);
            //foreach(var item in Results)
            //{
            //    Console.WriteLine($"Words starting with '{item.Key}':");
            //    foreach (var word in item)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q3. Consider this Array as an Input Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            var Result = Arr.GroupBy(word => string.Concat(word.OrderBy(C => C)));

            foreach (var item in Result)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine();
            }
            #endregion
            #endregion
        }
    }
}