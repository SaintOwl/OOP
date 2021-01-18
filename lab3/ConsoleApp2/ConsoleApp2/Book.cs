using System;

namespace ConsoleApp2
{
    class Book
    {
        public const int some_const = 100;
        public static int numOfBooks;
        public int id { get; }
        public string title { get; set; }
        public string author { get; set; } = "Неопределенно";
        public string issue { get; set; } = "Неопределенно";
        private int _publicationDate;
        public int publicationDate
        {
            get
            {
                return _publicationDate;
            }
            set
            {
                if (value < 0 && value > 2020)
                    Console.WriteLine("Ошибка: неверно указана дата!");
                else
                _publicationDate = value;
            }
        }
        private int _numOfPages;
        public int numOfPages 
        {
            get
            {
                return _numOfPages;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Ошибка: неверно указано количество страниц!");
                else
                _numOfPages = value;
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
                    Console.WriteLine("Ошибка: неверно указана цена!");
                else
                _price = value;
            }
        }
        public string typeOfBinding { get; set; } = "Неопределенно";

        static Book()
        {
            numOfBooks = 0;
        }

        public Book()
        {
            numOfBooks++;
            this.id = GetHashCode();
        }

        public Book(string title, string author, string issue, int date, int pages, int price, string binding)
        {
            numOfBooks++;
            this.id = GetHashCode();
            this.title = title;
            this.author = author;
            this.issue = issue;
            this.publicationDate = date;
            this.numOfPages = pages;
            this.price = price;
            this.typeOfBinding = binding;
        }

        public override string ToString()
        {
            return "\nBook: " + author + " " + title + " " + _publicationDate;
        }

        public static void author_name(string author, Book[] books_array)
        {
            Console.WriteLine($"Список книг, автора: {author}");
            int count = 0;
            foreach (Book a in books_array)
            {
                if (a.author == author)
                {
                    Console.Write($"\n{a.title}");
                    count++;
                }
            }
            if (count == 0) Console.WriteLine($"Книги автора ({author}) не найдены!");
        }

        public static void after_year(int year, Book[] books_array)
        {
            Console.WriteLine($"Список книг, после: {year}");
            int count = 0;
            foreach (Book a in books_array)
            {
                if (a._publicationDate > year )
                {
                    Console.Write($"\n{a.title}");
                    count++;
                }
            }
            if (count == 0) Console.WriteLine($"Все книги опубликованны до {year}!");
        }



        public void info()
        {
            Console.WriteLine($"ID: \t{id}\n" +
                $"Название: \t{title}\n" +
                $"Автор: \t{author}\n" +
                $"Издательство: \t{issue}\n" +
                $"Год публикации: \t{_publicationDate}\n" +
                $"Количество страниц: \t{_numOfPages}\n" +
                $"Цена: \t{_price}\n" +
                $"Тип переплета: \t{typeOfBinding}\n");

        }
    }
}
