using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class OverFlowException : Exception
    {
        public OverFlowException(string message) : base(message)
        {}
    }

    class ZeroDivision : Exception
    {
        public ZeroDivision(string str)
        {
            Console.WriteLine(str);
        }
        public static double SafeDivision(double a, double b)
        {
            if(b == 0)
            {
                throw new ZeroDivision("Внимание! Деление на 0!");
            }
            return a / b;
        }
    }

    class CreationException : Exception
    {
        public CreationException(string str)
        {
            Console.WriteLine(str);
        }
        public CreationException()
        {
            Console.WriteLine("Имя и возраст не могут быть пустыми!");
        }
    }
}
