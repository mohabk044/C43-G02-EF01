using static Assignment.ListGenerators;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Get the first 3 orders from customers in Washington
            //var Result = CustomerList.Where(C=> C.City == "Washington").Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2 - Get all but the first 2 orders from customers in Washington.
            var Result = CustomerList.Where(C => C.City == "Washington").Skip(2);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}