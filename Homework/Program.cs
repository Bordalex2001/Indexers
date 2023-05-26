using System;
using System.Collections.Generic;

namespace Homework
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Class BookList");
            BookList book_list = new BookList();
            Book book_1 = new Book("The Picture of Dorian Gray", "Oscar Wilde", 1890);
            Book book_2 = new Book("The Da Vinci Code", "Dan Brown", 2003);
            Book book_3 = new Book("Wish You Were Here", "Jodi Picoult", 2021);
            Book book_4 = new Book("The Improbability of Love", "Hannah Rothschild", 2015);
            Book book_5 = new Book("The Judgement of Strangers", "Andrew Taylor", 1997);
            book_list += book_1;
            book_list += book_2;
            book_list += book_3;
            book_list += book_4;
            book_list += book_5;
            Console.WriteLine("Book list for reading:");
            for (int i = 0; i < book_list.Books.Count; i++)
            {
                Console.WriteLine(book_list[i]);
            }
            Console.WriteLine("\nBook search by index: " + book_list[1]);
            Console.WriteLine("Book search by name: " + book_list["The Improbability of Love"]);
            Console.WriteLine("Book search by author and year: " + book_list["Jodi Picoult", 2021]);
            Console.WriteLine("\nBook list after changing books:");
            book_list[0] = new Book("Van Gogh: The Life", "Steven Naifeh", 2011);
            book_list[3] = new Book("Edward Munch: 1863-1944", "Ulrich Bischoff", 1990);
            for (int i = 0; i < book_list.Books.Count; i++)
            {
                Console.WriteLine(book_list[i]);
            }
            book_list -= book_3;
            book_list -= book_5;
            Console.WriteLine("\nBook list after removing books:");
            for (int i = 0; i < book_list.Books.Count; i++)
            {
                Console.WriteLine(book_list[i]);
            }
        }
    }
}