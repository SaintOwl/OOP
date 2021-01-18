using System;

namespace ConsoleApp2
{

    class Person
    {
        private int? _age;
        public int? age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0 || value > 150)
                {
                    throw new CreationException("Неверное указан возраст!");
                }
                _age = value;
            }
        }
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value == "")
                {
                    throw new CreationException("Имя не может быть пустым");
                }
                _name = value;
            }
        }

        public Person(int? age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Person()
        {
            age = null;
            name = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int res;
            double res1;
            try
            {
                int a = 2000000;
                int b = 2000000;
                res = checked(a * b);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                double a = 5;
                double b = 0;
                res1 = ZeroDivision.SafeDivision(a, b);
            }
            catch 
            {
                
            }

            try
            {
                Person per = new Person(18, "Nik");
                //Person per1 = new Person(-1, "Sam");
                //Person per2 = new Person(18, "");
                /*Person per3 = new Person();
                if(per3.name == null && per3.age == null)
                {
                    throw new CreationException();
                }*/
            }
            finally
            {
                Console.WriteLine("Finally выполняется всегда!");
            }
        }
    }
}
