using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(5);
            list.add(list, "list str;");
            list.add(list, "list str 2;");
            list.add(list, "list str 3;");
            list.Elements(list);
            list.delete(list, 2);
            list.Elements(list);

            List<int> list1 = new List<int>(5);
            list1.add(list1, 16);
            list1.add(list1, 32);
            list1.add(list1, 64);
            list1.Elements(list1);
            list1.delete(list1, 1);
            list1.Elements(list1);


            List<Journal> list2 = new List<Journal>(5);
            Journal journal0 = new Journal("Journal0", 100, "BindingJ", "AuthorJ", "Publishing HouseJ");
            Journal journal1 = new Journal("Journal1", 400, "BindingJ", "AuthorJ", "Publishing HouseJ");

            list2.add(list2, journal0);
            list2.add(list2, journal1);
            list2.Elements(list2);
            list2.delete(list2, 1);
            list2.Elements(list2);
        }
    }
}
