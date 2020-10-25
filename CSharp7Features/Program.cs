using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// /namespace CSharp7Features =>1
/// </summary>
//namespace CSharp7Features
//{
//    class Program
//    {
//        //-----------------------------------------------------------------------------------Local Functions
//        //static void Main(string[] args)
//        //{
//        //    num();
//        //    addTen(29);
//        //    void num()
//        //    {
//        //        Console.WriteLine("num");
//        //        Console.ReadKey();
//        //    }
//        //    int addTen(int a)
//        //    {
//        //        int sum = a + 10;
//        //        Console.WriteLine(sum);
//        //        return sum;
//        //    }
//        //    int myval = 1;
//        //    int cal(int n) => (n < 2) ? myval : cal(n - 1) + cal(n - 2);
//        //    Console.WriteLine(cal(8));
//        //    Console.ReadKey();
//        //}

//        //public IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
//        //{
//        //    if (source == null) throw new ArgumentNullException(nameof(source));
//        //    if (filter == null) throw new ArgumentNullException(nameof(filter));


//        //    return iterator();

//        //    IEnumerable<T> iterator()
//        //    {
//        //        foreach (var element in source)
//        //        {
//        //            if (filter(element))
//        //            {
//        //                yield return element; // => yield Return => اگه نزاریمش اولین مقداری که میگیره رو برمیگردونه 
//        //                //=> اما حالا که گزاشتیمش صبر میکنه تا حلقه فور ایچ کامل انجام بشه و بعدش همه همه مقادیر رو برمیگردونه
//        //            }
//        //        }
//        //    }
//        //}
//        //-------------------------------------------------------------------Tuple
//        static void Main(string[] args)
//        {
//            Tuple<string, string, int> Person = new Tuple<string, string, int>("Ruhollah", "Jafari", 26);
//            Tuple<string, string, int> Persons = Tuple.Create("Ruhollah", "Jafari", 26);

//            Console.WriteLine($"Name : {Persons.Item1} Family : {Persons.Item2} Age : {Persons.Item3}");
//            Console.WriteLine($"Name : {Person.Item1} Family : {Person.Item2} Age : {Person.Item3}");

//            Ex1();
//            Ex2();
//            Ex3();
//            Ex4();    //Using Method TupleSample And Set Data To It !
//            Console.ReadKey();
//            Ex5();
//            Console.ReadKey();
//        }

//        //---------------------------------------------------------------------------------------------------------------
//        //Using Tuple From Simple To Nested Tuple => در حالت معمول تاپل 7 تا ورودی میگیره اما اگه هشتمین تاپل رو دوباره تاپل بدهیم مقدار بیشتری میتونیم تاپل تعریف کنیم

//        static void Ex1()
//        {
//            var Person1 = new Tuple<string, string, int>("Ruhollah", "Jafari", 27);
//            Console.WriteLine($"Name : {Person1.Item1} Family : {Person1.Item2} Age : {Person1.Item3}");

//        }

//        static void Ex2()
//        {
//            var site = Tuple.Create("Jafari94.ir", "Ruhollah@jafari94.ir", "RuhollahJafari", "09198054320", "1");
//            Console.WriteLine($"{site.Item1} - {site.Item2} - {site.Item3} - {site.Item4} -{site.Item5}");
//        }
//        static void Ex3()
//        {
//            var nestedTuple = new Tuple<int, int, int, int, int, int, int,
//                Tuple<string, string, string, string, string, string, string>>
//                (1,2,3,4,5,6,7,Tuple.Create("R","U","H","O","L","L","A"));
//            Console.WriteLine("{0},{1},{2}",nestedTuple.Item3,nestedTuple.Rest.Item1 , nestedTuple.Rest.Item2);
//        }
//        //---------------------------------------------------------------------------------------------------------------

//        //-------------------------------------------------------------------------------------------
//        //Using Method TupleSample And Set Data To It !
//        static void Ex4()  
//        {
//            TupleSample ts = new TupleSample();
//            var person6 = Tuple.Create("Ruhollah", "J", 26);
//            ts.SetTupleInMethod(person6);
//        }

//        static void Ex5()
//        {
//            var P7 = TupleSample.GetTuple();
//            Console.WriteLine($"Name : {P7.Item1} Family : {P7.Item2} Age : {P7.Item3}");

//        }

//    }
//    public class TupleSample 
//    {
//        public void SetTupleInMethod(Tuple<string, string, int> Person4)
//        {
//            Console.WriteLine($"Name : {Person4.Item1} Family : {Person4.Item2} Age : {Person4.Item3}");
//        }
//    //-------------------------------------------------------------------------------------------

//        //تاپل خروجی بده
//        public static Tuple<string,string,int>GetTuple()
//        {
//            return Tuple.Create("Github", ".com", 2020);
//        }

//    }

//}



//-------------------------------------------------

//-------------------------------------------
/// <summary>
/// /namespace CSharp7Features =>2
/// </summary>
namespace CSharp7Features
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = TupleSample.GetNewTuple();
            Console.WriteLine($"name : {tp.Item1} , family : {tp.Item2} , Age : {tp.Item3} , ");
            Console.ReadKey();

            //-------------------------------------------------
            var tp2 = TupleSample.GetNewTuple2();
            Console.WriteLine($"name : {tp2.name} , family : {tp2.family} , Age : {tp2.age}  ");

        }
    }
    class TupleSample
    {
       public static (string , string , int) GetNewTuple() // Nuget => Install-Package "System.ValueTuple" -IncludePrerelease
        {
            string name = "Ruhollah";
            string family = "Jafari";
            int age = 26;
            return (name, family, age);
        }

        public static (string name, string family, int age) GetNewTuple2()  
        {
            string name = "Ruhollah";
            string family = "Jafari";
            int age = 96;
            return (name, family, age);
        }
    }
}