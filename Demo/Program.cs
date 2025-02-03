using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 - Quantifier Operators
            //// 1- Any
            //var Result = ProductList.Any();
            //Console.WriteLine(Result);
            //var Result2 = ProductList.Any(P=>P.UnitsInStock==0);
            //Console.WriteLine(Result2);
            //// 2- All
            //var Result3 = ProductList.All(P => P.UnitsInStock==0);
            //Console.WriteLine(Result3);
            //// 3- Contains
            //var Result4 = ProductList.Contains(ProductList[0]);
            //Console.WriteLine(Result4);
            //// 4- SequenceEqual
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(0, 100);
            //var Result5 = Seq01.SequenceEqual(Seq02);
            //Console.WriteLine(Result5);
            #endregion

            #region Video 02 - Transformationo Operators[Zipping]
            //List<string> Words = new List<string>() { "ten", "twenty", "Thirty", "Fourty" };
            //int[] Num = { 10, 20, 30, 40, 50, 60 };
            //var result01 = Num.Zip(Words); //First Overload
            //var result02 = Num.Zip(Words, (Num, Words) => $"{Num}= {Words}"); //Third Overload
            //var result03 = Num.Zip(Words, [1, 2, 3]); //Second Overload
            //foreach (var item in result03)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Video 03 - Grouping Operatotrs
            //Ex01:
            var result = ProductList.GroupBy(p => p.Category);
            result = from p in ProductList
                     group p by p.Category;
            result = ProductList.GroupBy(p => p.Category);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item1 in item)
                {
                    Console.WriteLine($"::: {item1}");
                }
            }
            //Ex02:
            var result02 = ProductList.Where(p => p.UnitsInStock > 0)
            .GroupBy(p => p.Category)
            .Where(ProductGroup => ProductGroup.Count() > 10).Select(ProductGroup => new
            {
                category = ProductGroup.Key,
                count = ProductGroup.Count()
            });
            result02 = from p in ProductList
                       where p.UnitsInStock > 0
                       group p by p.Category
                       into ProductGroup
                       where ProductGroup.Count() > 10
                       select new
                       {
                           category = ProductGroup.Key,
                           count = ProductGroup.Count()
                       };
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}