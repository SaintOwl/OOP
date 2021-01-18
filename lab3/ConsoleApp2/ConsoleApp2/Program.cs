using System;

namespace ConsoleApp2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books_array = new Book[10];

            Book book = new Book();
            books_array[0] = book;

            Book book1 = new Book("Капитанская дочка", "Пушкин", "Издательство 1", 1841, 130, 53, "Жесткий");
            books_array[1] = book1;

            Book book2 = new Book("Евгение Онегин", "Пушкин", "Издательство 1", 1833, 736, 106, "Жесткий");
            books_array[2] = book2;

            Book book3 = new Book("Дубровский", "Пушкин", "Издательство 1", 1833, 90, 33, "Мягкий");
            books_array[3] = book3;

            Book book4 = new Book("Демон", "Лермонтов", "Издательство 2", 1841, 21, 22, "Мягкий");
            books_array[4] = book4;

            Book book5 = new Book("Песня про царя Ивана", "Лермонтов", "Издательство 2", 1837, 13, 22, "Мягкий");
            books_array[5] = book5;

            Book book6 = new Book("Бородино", "Лермонтов", "Издательство 2", 1837, 2, 22, "Жесткий");
            books_array[6] = book6;

            Book book7 = new Book("Хорошо и плохо", "Маяковский", "Издательство 3", 1925, 1, 22, "Жесткий");
            books_array[7] = book7;

            Book book8 = new Book("Облако в штанах", "Маяковский", "Издательство 3", 1915, 110, 55, "Жесткий");
            books_array[8] = book8;

            Book book9 = new Book("Тучкины штучки", "Маяковский", "Издательство 3", 1925, 1, 22, "Жесткий");
            books_array[9] = book9;

            Console.WriteLine("\nВведите автора");
            Book.author_name(Console.ReadLine(), books_array);
            Console.WriteLine("\nВведите год");
            Book.after_year(Convert.ToInt32(Console.ReadLine()), books_array);

            Console.WriteLine(book1);
            var book_unk = new { author = "Unk author", title = "Unk title", date = 1950 }; //var имя = new {}
            Console.WriteLine("Aнонимный тип" + "\n" + book_unk.GetType());
            Console.WriteLine("Количество книг: " + Book.numOfBooks);
        }
    }
}
