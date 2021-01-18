using System;

namespace ConsoleApp2
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
        void IAction.inspect()
        {
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
}
