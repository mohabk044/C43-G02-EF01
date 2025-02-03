using static Assignment.ListGenerators;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Get the first 3 orders from customers in Washington
            var Result = CustomerList.Where(C => C.City == "Washington").Take(3);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}