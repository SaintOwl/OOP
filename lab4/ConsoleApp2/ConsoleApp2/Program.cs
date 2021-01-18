using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List("str");
            list1.Add("str1");
            list1.Add("lag str ev");
            list1.Lagest();
            Console.WriteLine(list1.str[0] + ' ' + list1.str[1] + ' ' + list1.str[2]);

            List list2 = new List("str2");
            list2.Add("str3");
            list2.Add("str for remove");

            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);
            list2.Remove("str for remove");
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);

            list2.Add("remove at 2");
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);
            list2.RemoveAt(2);
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);

            list2.Add("last str");
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);
            list2.RemoveLast();
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);

            list2.Add("lag str ev 2.0");
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2]);
            list2.Lagest();

            string srt = "sdfrg";
            list2 = list2 + "efrfrrgg";
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2] + ' ' + list2.str[3]);
            list2 = list2 >> 3;
            Console.WriteLine(list2.str[0] + ' ' + list2.str[1] + ' ' + list2.str[2] + ' ' + list2.str[3]);

            List.Owner owner = new List.Owner();
            Console.WriteLine(owner.ToString());
            List.Date date = new List.Date();
            Console.WriteLine(date.ToString());

            StaticOp.NumOfElements("asd a zxczxczxczxc");
        }
    }
}
