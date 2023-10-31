using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_22_10_PU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercises_2.Run();

            // 1 ---------------

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> query = from even  in numbers
            //                         where even % 2 != 1
            //                         select even;

            //foreach (int number in query)
            //{
            //    Console.WriteLine(number);
            //}

            // 2 ---------------

            //int[] ints = new int[] { 1, -2, -5, 87, 54, -87, 55 };

            //IEnumerable<int> query = from x in ints
            //                         where x > 0
            //                         select x;

            //foreach (int number in query)
            //{
            //    Console.WriteLine(number);
            //}

            // 3 ---------------

            //int[] numbers = new int[] {1, 2 , 3, 4, 5, 6, 7, 8};

            //var query = from  num in numbers
            //                         let temp = num * num
            //                         where temp > 20
            //                         select new { num, temp };

            //foreach (var nums in query)
            //{
            //    Console.WriteLine($"Number:{nums.num} Squere: {nums.temp}");
            //}

            // 4 ---------------

            //int[] numbers = new int[] { 55, 54, 54, 55, 8, 9, 55, 4, 9, 5, 4, 1, 33, 5, 9 };

            //var query = from x in numbers
            //        group x by x into y
            //        select y;

            //foreach (var arrNo in n)
            //{
            //    Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            //}

            // 5 ---------------

            //Console.Write("Enter the string: ");
            //string str = Console.ReadLine();

            //var query = from text in str
            //            group text by text into txt
            //            select txt;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Key + " " + item.Count());
            //}

            // 6 ---------------

            //string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //IEnumerable<string> query = from day in weekDays
            //                            select day;

            //foreach (string day in query)
            //{
            //    Console.WriteLine(day);
            //}

            // 7 ---------------

            //int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var query = from num in numbers
            //            group num by num into nums
            //            select nums;

            //foreach (var num in query)
            //{
            //    var temp = num.Count();
            //    Console.WriteLine(num.Key + " " + num.Key * temp + " " + temp);
            //}

            // 8 ---------------

            //string[] cities = new string[] { "Toshkent", "Samarqand", "Buxoro", "Xorazm", "Farg'ona" };

            //var query = from c in cities
            //            select c;

            //foreach (var city in query)
            //{
            //    Console.WriteLine($"The city starting with {city[0]} and ending with {city[city.Length-1]} is: {city}");
            //}

            // 9 ---------------

            //int[] numbers = new int[] { 34, 23, 5554, 453, 23, 23, 54, 87, 89, 99, 997, 990 };

            //IEnumerable<int> query = from num in numbers
            //                         where num > 80
            //                         select num;

            //foreach (int num in query)
            //{
            //    Console.WriteLine(num);
            //}

            // 10 ---------------

            //int n; 
            //int temp;
            //List<int> list = new List<int>();

            //Console.Write("Write how many numbers you are entering: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the number: ");
            //    temp = int.Parse(Console.ReadLine());
            //    list.Add(temp);
            //}

            //Console.Write("\nInput the value above you want to display the members of the List : ");
            //n = int.Parse(Console.ReadLine());

            //List<int> filteredList = list.FindAll(x => x > n);

            //foreach (int i in filteredList)
            //{
            //    Console.WriteLine(i);
            //}

            // 11 ---------------

            //int n;
            //int temp;
            //List<int> list = new List<int>();

            //Console.Write("Write how many numbers you are entering: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the number: ");
            //    temp = int.Parse(Console.ReadLine());
            //    list.Add(temp);
            //}

            //Console.Write("\nHow many records you want to display ?: ");
            //n = int.Parse(Console.ReadLine());

            //list.Sort();
            //list.Reverse();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            // 12 ---------------

            //Console.Write("Enter the string: ");
            //string text = Console.ReadLine();

            //var result = text.Split(' ').Where(x => x.ToUpper() == x);

            //foreach (var str in result)
            //{
            //    Console.WriteLine(str);
            //}

            // 13 ---------------

            //int n;
            //string temp, permanent = "";
            //List<string> list = new List<string>();

            //Console.Write("Write how many strings you are entering: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the string: ");
            //    temp = Console.ReadLine();
            //    list.Add(temp);
            //    permanent += (temp + ", ");
            //}

            //Console.WriteLine(permanent);

            // 16 ---------------

            //string[] files = Directory.GetFiles(@"D:\Multfilms");

            //var avgSize = files.Select(f => new FileInfo(f).Length).Average();
            //avgSize = Math.Round(avgSize / 10, 1);

            //Console.WriteLine(avgSize);

            // 17 ---------------

            //List<string> charsList = new List<string>();
            //charsList.Add("m");
            //charsList.Add("n");
            //charsList.Add("o");
            //charsList.Add("p");
            //charsList.Add("q");

            //var result = from y in charsList
            //             select y;

            //string newstr = charsList.FirstOrDefault(en => en == "p");
            //charsList.Remove(newstr);


            //var result2 = from z in charsList
            //              select z;

            //foreach (var Char in result2)
            //{
            //    Console.WriteLine(Char);
            //}

            // 18 ---------------

            //List<string> charsList = new List<string>();
            //charsList.Add("m");
            //charsList.Add("n");
            //charsList.Add("o");
            //charsList.Add("p");
            //charsList.Add("q");

            //var result = from y in charsList
            //             select y;

            //charsList.Remove(charsList.FirstOrDefault(e => e == "p"));

            //var result2 = from z in charsList
            //              select z;

            //foreach (var Char in result2)
            //{
            //    Console.WriteLine(Char);
            //}

            // 19 ---------------

            //List<string> charsList = new List<string>();
            //charsList.Add("m");
            //charsList.Add("n");
            //charsList.Add("o");
            //charsList.Add("p");
            //charsList.Add("q");

            //var result = from y in charsList
            //             select y;

            //charsList.RemoveAll(e => e == "q");

            //var result2 = from z in charsList
            //              select z;

            //foreach (var Char in result2)
            //{
            //    Console.WriteLine(Char);
            //}

            // 20 ---------------

            //List<string> charsList = new List<string>();
            //charsList.Add("m");
            //charsList.Add("n");
            //charsList.Add("o");
            //charsList.Add("p");
            //charsList.Add("q");

            //var result = from y in charsList
            //             select y;

            //charsList.RemoveAt(1);

            //var result2 = from z in charsList
            //              select z;

            //foreach (var Char in result2)
            //{
            //    Console.WriteLine(Char);
            //}
        }
    }
}
