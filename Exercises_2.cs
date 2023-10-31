using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_22_10_PU
{
    internal class Exercises_2
    {
        public static void Run()
        {
            // 21 ---------------

            //List<string> charslist = new list<string>();
            //charslist.add("m");
            //charslist.add("n");
            //charslist.add("o");
            //charslist.add("p");
            //charslist.add("q");

            //var result = from y in charslist
            //             select y;

            //charslist.removerange(1, 3);

            //var result2 = from z in charslist
            //              select z;

            //foreach (var char in result2)
            //{
            //    console.writeline(char);
            //}

            // 22 ---------------

            //int n;
            //string temp;
            //List<string> list = new List<string>();

            //Console.Write("Write how many strings you are entering: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the string: ");
            //    temp = Console.ReadLine();
            //    list.Add(temp);
            //}

            //Console.Write("Enter the number: ");
            //n = int.Parse(Console.ReadLine());

            //IEnumerable<string> permanent = from str in list
            //                                where str.Length > n
            //                                select str;

            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}

            // 23 ---------------

            //string[] chars = new string[] { "A", "B", "C" };
            //int[] ints = { 1, 2, 3 };

            //var query = from c in chars
            //            from n in ints
            //            select new { c, n};

            //foreach ( var item in query )
            //{
            //    Console.WriteLine(item);
            //}

            // 24 ---------------

            //string[] chars = new string[] { "A", "B", "C" };
            //int[] ints = { 1, 2, 3 };
            //string[] colorset = { "Green", "Orange" };

            //var query = from c in chars
            //            from n in ints
            //            from str in colorset
            //            select new { c, n, str };

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            // 25 ---------------

            //List<Fruits> itemlist = new List<Fruits>
            //    {
            //    new Fruits { Id = 1, Name = "Biscuit  " },
            //    new Fruits { Id = 2, Name = "Chocolate" },
            //    new Fruits { Id = 3, Name = "Butter   " },
            //    new Fruits { Id = 4, Name = "Brade    " },
            //    new Fruits { Id = 5, Name = "Honey    " }
            //    };

            //List<Purchase> purchlist = new List<Purchase>
            //    {
            //    new Purchase { PurchaseId=100, Id = 3,  Cost = 800 },
            //    new Purchase { PurchaseId=101, Id = 2,  Cost = 650 },
            //    new Purchase { PurchaseId=102, Id = 3,  Cost = 900 },
            //    new Purchase { PurchaseId=103, Id = 4,  Cost = 700 },
            //    new Purchase { PurchaseId=104, Id = 3,  Cost = 900 },
            //    new Purchase { PurchaseId=105, Id = 4,  Cost = 650 },
            //    new Purchase { PurchaseId=106, Id = 1,  Cost = 458 }
            //    };

            //var innerJoin = from e in itemlist
            //                join d in purchlist on e.Id equals d.Id
            //                select new
            //                {
            //                    itid = e.Id,
            //                    itdes = e.Name,
            //                    prqty = d.Cost
            //                };

            //foreach (var data in innerJoin)
            //{
            //    Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            //}

            // 28 ---------------

            //         string[] cities = new string[] { "Toshkent", "Samarqand", "Buxoro", "Xorazm", "Farg'ona" };

            //         IEnumerable<string> cityOrder = cities.OrderBy(str => str.Length)
            //                                               .ThenBy(str => str);

            //foreach (string city in cityOrder)
            //	Console.WriteLine(city);

            // 30 ---------------

            //static List<Fruits> GetItemMast()
            //{
            //    List<Fruits> itemlist = new List<Fruits>();
            //    itemlist.Add(new Fruits() { Id = 1, Name = "Biscuit  " });
            //    itemlist.Add(new Fruits() { Id = 2, Name = "Honey    " });
            //    itemlist.Add(new Fruits() { Id = 3, Name = "Butter   " });
            //    itemlist.Add(new Fruits() { Id = 4, Name = "Brade    " });
            //    itemlist.Add(new Fruits() { Id = 5, Name = "Honey    " });
            //    itemlist.Add(new Fruits() { Id = 6, Name = "Biscuit  " });
            //    return itemlist;
            //}

            //var itemlist = (from c in GetItemMast()
            //                select c.Name)
            //        .Distinct()
            //        .OrderBy(x => x);

            //foreach( var item in itemlist )
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
