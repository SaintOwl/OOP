using System;

namespace ConsoleApp1
{
    public partial class Library
    {
        public static int numOfBooks;
        public string title;
        public string author;
        private int _dateOfPublishing;
        public int dateOfPublishing
        {
            get
            {
                return _dateOfPublishing;
            }
            set
            {
                if (value < 1500 || value > 2020)
                    Console.WriteLine("Дата указана неверно!");
                else
                    _dateOfPublishing = value;
            }
        }
        private int _price;
        public int price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Цена не может быть отрицательная!");
                else
                    _price = value;
            }
        }
    }
}
