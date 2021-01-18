using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void task1()
        {
            //определение и инициализация
            bool a = true;
            Console.WriteLine("Введите tp byte");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите tp sbyte");
            sbyte c = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите tp char");
            char d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите tp decimal");
            decimal e = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите tp double");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите tp float");
            float g = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите tp int");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите tp uint");
            uint i = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите tp long");
            long j = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите tp ulong");
            ulong k = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите tp short");
            short l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите tp ushort");
            ushort m = Convert.ToUInt16(Console.ReadLine());

            //явное и неявное приведение
            int a1 = 112;
            long b1 = a1;
            float c1 = b1;

            byte bb = (byte)a1;
            short cc = (short)bb;
            double dd = (double)cc;

            //упаковки и распаковка зт
            int ii = 125;
            object o = ii; //упаковка
            int ii2 = (int)o; //распаковка

            //неявно типизированная переменная
            var str1 = "OOP Is The Best!";
            string str2 = "OFC";
            Console.WriteLine(str1 + " " +str2);

            //тп nullable
            int? x1 = null;
            int? x2 = null;
            Console.Write(x1 == x2); //True

            Console.ReadKey();
        }

        static void task2()
        {
            String str0 = "D:\\labs\\oop\\";
            String str1 = "file.cs";
            String str11 = "file.cs";
            String str2 = "smth intrst";
            String str22 = "smth intrst";
            String str3 = "zxc vbn nm, asd ";
            String emp_str;

            Console.WriteLine(String.Concat(str0, str1));
            emp_str = String.Copy(str2);
            Console.WriteLine(emp_str);
            emp_str = str2.Substring(5);
            Console.WriteLine(emp_str);
            String[] words = str3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int cnt = 0; cnt < words.Length; cnt++){
                Console.WriteLine(words[cnt]);
            }

            str22 = str22.Insert(5, str3);
            Console.WriteLine(str22);
            Console.WriteLine(emp_str = emp_str.Remove(0, 2));
            Console.WriteLine($"There is {str0}{str1} {str2} here!");

            String emp_str1 = null;
            if (String.IsNullOrEmpty(emp_str1))
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Console.WriteLine("String isnt empty");
            }

            StringBuilder SB = new StringBuilder("I don't like OOP");
            SB.Remove(2, 6);
            SB.Append("!");
            SB.Insert(2, "really ");
            Console.WriteLine(SB);
        }

        static void task3()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[][] c = new int[3][];
            c[0] = new int[2];
            c[1] = new int[3];
            c[2] = new int[4];
            for (int i = 0; i < 2; i++)
            {
                c[0][i] = i;
                Console.Write("{0}\t", c[0][i]);
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                c[1][i] = i;
                Console.Write("{0}\t", c[1][i]);
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                c[2][i] = i;
                Console.Write("{0}\t", c[2][i]);
            }

            Console.WriteLine();


            var g = new int[5];
            var p = "new str";
        }

        static void task4()
        {
            (int a, string b, char c, string d, ulong e) a = (5, "sss", 's', "sss", 155644);
            Console.WriteLine(a);
            Console.WriteLine(a.Item2);
            Console.WriteLine(a.Item5);
            Console.WriteLine(a.Item3);
            //UNPACK
            Console.WriteLine(a.a);
            Console.WriteLine(a.b);

            int[] arr = { 2, 1, 4, 5, 3 };
            fun(arr,"abcdefg");

            //check();
            uncheck();


            (int, int, int, char) fun(int[] a, string b)
            {
                int max = a.Max<int>();
                int min = a.Min<int>();
                int sum = a.Sum();
                (int, int, int, char) kor = (max, min, sum, b[0]);
                Console.WriteLine(kor);
                return kor;
            }
        }


        static void check()
        {
            checked
            {
                int a = 2147483647;
                Console.WriteLine(a + 1);
            }
        }
        static void uncheck()
        {
            unchecked
            {
                int a = 2147483647;

                Console.WriteLine(a + 1);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1 - Типы");
            Console.WriteLine("2 - Строки");
            Console.WriteLine("3 - Массивы");
            Console.WriteLine("4 - Кортежи");
            Console.WriteLine("5 - Выход");
            Console.WriteLine("Введите номер задания: ");

            int swt = Convert.ToInt32(Console.ReadLine());
            while (swt != 5)
            {
                switch (swt)
                {
                    case 1: task1(); break;
                    case 2: task2(); break;
                    case 3: task3(); break;
                    case 4: task4(); break;
                    case 5: return;
                }

                Console.WriteLine("\n1 - Типы");
                Console.WriteLine("2 - Строки");
                Console.WriteLine("3 - Массивы");
                Console.WriteLine("4 - Кортежи");
                Console.WriteLine("5 - Выход");
                Console.WriteLine("Введите номер задания: ");

                swt = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}