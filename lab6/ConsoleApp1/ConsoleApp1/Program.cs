using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Library
    {
        static Library()
        {
            numOfBooks = 0;
        }
        public Library()
        {
            numOfBooks++;
            this.title = "Нет данных";
            this.author = "Нет данных";
            this.dateOfPublishing = 1501;
            this.price = 0;
        }
        public Library(string title, string author, int date, int price)
        {
            numOfBooks++;
            this.title = title;
            this.author = author;
            this.dateOfPublishing = date;
            this.price = price;
        }

        public void info()
        {
            Console.WriteLine($"\nНазвание: {this.title}\n" +
                              $"Автор: {this.author}\n" +
                              $"Дата выпуска: {this.dateOfPublishing}\n" +
                              $"Цена: {this.price}");
        }

        public static void infoNumOfBooks()
        {
            Console.WriteLine($"Количество книг: {numOfBooks}");
        }
    }


    enum bookBorrowed
    {
        one = 1,
        two,
        three,
        four,
        five
    }

    public struct Visitor
    {
        public string name;
        public int age;
        private Guid id;

        public Visitor(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.id = Guid.NewGuid();
        }

        public void visitorInfo()
        {
            Console.WriteLine($"\nИмя посетителя: {this.name}\n" +
                              $"Возраст: {age}\n"// +
                              //$"ID: {this.id}"
                              );
        }
    }
    abstract class PrintedEdition
    {
        public string title;
        public int numOfPages;
        public string binding;
        public string author;
        public string publishingHouse;
    }

   

    class Journal : PrintedEdition, IAction
    {
        public Journal()
        {
            this.title = "";
            this.numOfPages = 0;
            this.binding = "";
            this.author = "";
            this.publishingHouse = "";
        }
        public Journal(string _title, int _numOfPages, string _binding, string _author, string _publishingHouse)
        {
            this.title = _title;
            this.numOfPages = _numOfPages;
            this.binding = _binding;
            this.author = _author;
            this.publishingHouse = _publishingHouse;
        }
        public void inspect()
        {
            Console.WriteLine("Inspect journal");
        }
        public void preview()
        {
            Console.WriteLine("Preview journal");
        }
        public void read()
        {
            Console.WriteLine("Read journal");
        }
        public override string ToString()
        {
            return $"Journal title: {this.title}\n" +
                   $"Pages: {this.numOfPages}\n" +
                   $"Binding: {this.binding}\n" +
                   $"Author: {this.author}\n" +
                   $"Publishing House: {this.publishingHouse}\n";
        }
    }

    class Textbook : PrintedEdition, IAction
    {
        public Textbook()
        {
            this.title = "";
            this.numOfPages = 0;
            this.binding = "";
            this.author = "";
            this.publishingHouse = "";
        }
        public Textbook(string _title, int _numOfPages, string _binding, string _author, string _publishingHouse)
        {
            this.title = _title;
            this.numOfPages = _numOfPages;
            this.binding = _binding;
            this.author = _author;
            this.publishingHouse = _publishingHouse;
        }
        public void inspect()
        {
            Console.WriteLine("Inspect textbook");
        }
        public void preview()
        {
            Console.WriteLine("Preview textbook");
        }
        public void read()
        {
            Console.WriteLine("Read textbook");
        }
        public override string ToString()
        {
            return $"Textbook title: {this.title}\n" +
                   $"Pages: {this.numOfPages}\n" +
                   $"Binding: {this.binding}\n" +
                   $"Author: {this.author}\n" +
                   $"Publishing House: {this.publishingHouse}\n";
        }
    }

    class Book : PrintedEdition, IAction
    {
        public Book()
        {
            this.title = "";
            this.numOfPages = 0;
            this.binding = "";
            this.author = "";
            this.publishingHouse = "";
        }
        public Book(string _title, int _numOfPages, string _binding, string _author, string _publishingHouse)
        {
            this.title = _title;
            this.numOfPages = _numOfPages;
            this.binding = _binding;
            this.author = _author;
            this.publishingHouse = _publishingHouse;
        }
        public void inspect()
        {
            Console.WriteLine("Inspect book");
        }
        public void preview()
        {
            Console.WriteLine("Preview book");
        }
        public void read()
        {
            Console.WriteLine("Read book");
        }
        public override string ToString()
        {
            return $"Book title: {this.title}\n" +
                   $"Pages: {this.numOfPages}\n" +
                   $"Binding: {this.binding}\n" +
                   $"Author: {this.author}\n" +
                   $"Publishing House: {this.publishingHouse}\n";
        }
    }

    interface IAction
    {
        void inspect();
        void preview();
        void read();
    }

    class Printer
    {
        public void iAmPrinting(IAction obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
    class CLASS
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //---------------------LAB5--------------------------
            /*Journal journal0  = new Journal("Journal0", 100, "BindingJ", "AuthorJ", "Publishing HouseJ");
            Textbook textbook0 = new Textbook("Textbook0", 200, "BindingT", "AuthorT", "Publishing HouseT");
            Book book0 = new Book("Book0", 300, "BindingB", "AuthorB", "Publishing HouseB");
            Journal journal1 = new Journal("Journal1", 400, "BindingJ", "AuthorJ", "Publishing HouseJ");
            Textbook textbook1 = new Textbook("Textbook1", 500, "BindingT", "AuthorT", "Publishing HouseT");
            Book book1 = new Book("Book1", 600, "BindingB", "AuthorB", "Publishing HouseB");

            Console.WriteLine(journal0.ToString());
            Console.WriteLine(book1.ToString());

            book1.preview();
            book1.inspect();
            book1.read();

            Boolean test = book0 is Book;
            Console.WriteLine(test);
            Console.WriteLine(textbook0 is CLASS);

            Textbook textbook2 = new Textbook("Textbook2", 700, "BindingT", "AuthorT", "Publishing HouseT");
            PrintedEdition printedEdition = textbook2 as PrintedEdition;


            IAction[] arr = { journal0, textbook2, book1 };
            Printer printer = new Printer();
            for (int i = 0; i < arr.Length; i++)
            {
                printer.iAmPrinting(arr[i]);
            }*/



            //---------------------LAB6--------------------------
            Visitor Viktor = new Visitor("Виктор", 38);
            Viktor.visitorInfo();

            List<Library> BookArr = new List<Library>();

            Library book = new Library("Title", "Author", 2020, 100);
            BookArr.Add(book);
            Library book1 = new Library("Title1", "Author1", 0, -4);
            BookArr.Add(book1);
            Library book2 = new Library("Title2", "Author2", 2019, 200);
            BookArr.Add(book2);

            book2.info();

            Library.infoNumOfBooks();

            int total = 0;
            foreach(Library somebook in BookArr)
            {
                total += somebook.price;
            }
            Console.WriteLine($"Общая стоимость книг: {total}.\n");
        }
    }
}
