using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    num();
        //    addTen(29);
        //    void num()
        //    {
        //        Console.WriteLine("num");
        //        Console.ReadKey();
        //    }
        //    int addTen(int a)
        //    {
        //        int sum = a + 10;
        //        Console.WriteLine(sum);
        //        return sum;
        //    }
        //    int myval = 1;
        //    int cal(int n) => (n < 2) ? myval : cal(n - 1) + cal(n - 2);
        //    Console.WriteLine(cal(8));
        //    Console.ReadKey();
        //}

        //public IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
        //{
        //    if (source == null) throw new ArgumentNullException(nameof(source));
        //    if (filter == null) throw new ArgumentNullException(nameof(filter));


        //    return iterator();

        //    IEnumerable<T> iterator()
        //    {
        //        foreach (var element in source)
        //        {
        //            if (filter(element))
        //            {
        //                yield return element; // => yield Return => اگه نزاریمش اولین مقداری که میگیره رو برمیگردونه 
        //                //=> اما حالا که گزاشتیمش صبر میکنه تا حلقه فور ایچ کامل انجام بشه و بعدش همه همه مقادیر رو برمیگردونه
        //            }
        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            Tuple<string, string, int> Person = new Tuple<string, string, int>("Ruhollah", "Jafari", 26);
            Tuple<string, string, int> Persons = Tuple.Create("Ruhollah", "Jafari", 26);

            Console.WriteLine($"Name : {Person.Item1} Family : {Person.Item2} Age : {Person.Item3}");
        }
  }  
}
