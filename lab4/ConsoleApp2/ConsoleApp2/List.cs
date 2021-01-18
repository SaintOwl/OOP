using System;
using System.Globalization;

namespace ConsoleApp2
{
    class List
    {
        public string[] str = new string[50];
        public int count = 0;

        public class Owner
        {
            private static int id;
            private static string name;
            private static string fac;
            static Owner()
            {
                id = 1;
                name = "Max";
                fac = "FIT";
            }
            public override string ToString()
            {
                return "Owner: id - " + id + ", name - " + name + ", faculty - " + fac;
            }
        }
        public class Date
        {
            private static int day;
            private static int month;
            private static int year;
            static Date()
            {
                day = 10;
                month = 10;
                year = 2020;
            }
            public override string ToString()
            {
                return "Date: day - " + day + ", month - " + month + ", year  - " + year;
            }
        }
        public List()
        {

        }

        public List(string a)
        {
            if (this.count == 0)
            {
                this.str[0] = a;
            }
            else
                this.str[this.count] = a;
            this.count++;
        }

        public void Add(string a)
        {
            if (this.count == 0)
            {
                this.str[0] = a;
            }
            else
                this.str[this.count] = a;
            this.count++;
        }

        public void Remove(string a)
        {
            int num = 0;
            for(int i = 0; i < this.count; i++)
            {
                if (this.str[i] == a)
                {
                    this.str[i] = null;
                    num++;
                    this.count--;
                }
            }
            if (num == 0)
                Console.WriteLine("Элемент не найден!");
        }

        public void RemoveAt(int pos)
        {
            int num = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (i == pos)
                {
                    this.str[i] = null;
                    num++;
                    this.count--;
                }
            }

            if (num == 0)
                Console.WriteLine("Элемент не найден!");
        }

        public void RemoveLast()
        {
            if (this.count == 0)
                return;
            int i = this.count;
            if (this.str[i] == null)
                i = --this.count;
            this.str[i] = null;
        }

        public void Lagest()
        {
            int len = 0;
            int lagest = 0;
            for(int i = 0; i < this.count; i++)
            {
                if(this.str[i].Length > len)
                {
                    lagest = i;
                }
            }
            Console.WriteLine($"Строка на позиции {lagest} самая длинная: {this.str[lagest]}");
        }

        public static List operator + (List someList, string a)
        {
            someList.str[someList.count] = a;
            someList.count++;
            return someList;
        }

        public static List operator >>(List someList, int pos)
        {
            for (int i = 0; i <= someList.count; i++)
            {
                if (i == pos)
                {
                    someList.str[i] = null;
                }
            }
            return someList;
        }
    }

    public static class StaticOp
    {
        public static void NumOfElements(string a)
        {
            int max = 0;
            int numOfSymbols = 0;
            string lagest_string = "";
            string[] words = a.Split(new char[] { ' ' });
            for(int i = 0; i < words.Length; i++)
            {
                numOfSymbols = words[i].Length;
                if (numOfSymbols > max)
                {
                    max = numOfSymbols;
                    lagest_string = words[i];
                }
            }
            Console.WriteLine($"Самое длиное слово в строке {lagest_string}, количество символов {max}");
        }
    }
}
