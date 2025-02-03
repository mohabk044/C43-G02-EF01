using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 
            // 1- Any
            var Result = ProductList.Any();
            Console.WriteLine(Result);
            var Result2 = ProductList.Any(P => P.UnitsInStock == 0);
            Console.WriteLine(Result2);
            // 2- All
            var Result3 = ProductList.All(P => P.UnitsInStock == 0);
            Console.WriteLine(Result3);
            // 3- Contains
            var Result4 = ProductList.Contains(ProductList[0]);
            Console.WriteLine(Result4);
            // 4- SequenceEqual
            var Seq01 = Enumerable.Range(0, 100);
            var Seq02 = Enumerable.Range(0, 100);
            var Result5 = Seq01.SequenceEqual(Seq02);
            Console.WriteLine(Result5);
            #endregion
        }
    }
}