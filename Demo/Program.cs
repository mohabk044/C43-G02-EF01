using static Assignment.ListGenerators;
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
            var result = ProductList.Where(p => p.UnitsInStock == 0).GroupBy(p => p.Category);
            foreach (var item in result)
            {
                Console.WriteLine($"*{item.Key}*");
                foreach (var item1 in item)
                {
                    Console.WriteLine($"==>> {item1}");
                }
                Console.WriteLine();
            }
            #endregion
            #endregion
        }
    }
}