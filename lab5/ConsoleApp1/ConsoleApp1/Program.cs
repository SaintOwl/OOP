using System;

namespace ConsoleApp1
{
    abstract class PrintedEdition
    {
        public string title;
        public int numOfPages;
        public string binding;
        public string author;
        public string publishingHouse;
        public virtual void inspect() { }
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
        public override void inspect()
        {
            Console.WriteLine("Inspect journal(class)");
        }
        
        void IAction.inspect()
        {
            Console.WriteLine("Inspect journal(interface)");
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
        public override void inspect()
        {
            Console.WriteLine("Inspect textbook(class)");
        }
        void IAction.inspect() {
            Console.WriteLine("Inspect textbook(interface)");
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

    sealed class Book : PrintedEdition, IAction
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
        public override void inspect()
        {
            Console.WriteLine("Inspect book(class)");
        }
        void IAction.inspect()
        {
            Console.WriteLine("Inspect book(interface)");
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
    class CLASS //: Book
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal0  = new Journal("Journal0", 100, "BindingJ", "AuthorJ", "Publishing HouseJ");
            Textbook textbook0 = new Textbook("Textbook0", 200, "BindingT", "AuthorT", "Publishing HouseT");
            Book book0 = new Book("Book0", 300, "BindingB", "AuthorB", "Publishing HouseB");
            Journal journal1 = new Journal("Journal1", 400, "BindingJ", "AuthorJ", "Publishing HouseJ");
            Textbook textbook1 = new Textbook("Textbook1", 500, "BindingT", "AuthorT", "Publishing HouseT");
            Book book1 = new Book("Book1", 600, "BindingB", "AuthorB", "Publishing HouseB");

            Console.WriteLine(journal0.ToString());

            book1.preview();
            book1.inspect();
            ((IAction)book1).inspect();
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
            }
        }
    }
}
