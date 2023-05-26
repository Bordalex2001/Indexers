using System;
using System.Collections.Generic;

namespace Homework
{
    internal class Book
    {
        private string name; //название книги
        private string author; //автор книги
        private int year; //год издания
        public Book()
        {
            name = null;
            author = null;
            year = 0;
        }
        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public string Author
        {
            get { return author; } set { author = value; }
        }
        public int Year
        {
            get { return year; } set { year = value; }
        }
        public override string ToString()
        {
            return $"–{name} by {author}, {year}";
        }
    }
    internal class BookList
    { 
        private List<Book> books; //список книг
        public BookList()
        { 
            books = new List<Book>(); 
        }
        public BookList(List<Book> books)
        { 
            this.books = books; 
        }
        public List<Book> Books
        {
            get { return books; } set { books = value; }
        }
        public Book this[int index] //поиск и замена книги по индексу
        {
            get //поиск
            { 
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                else
                {
                    throw new Exception("Book not found by this index.");
                }
            } 
            set //замена
            { 
                if (index >= 0 && index < books.Count) 
                {
                    books[index] = value;
                }
                else
                {
                    throw new Exception("Unable to change book data by this index.");
                }
            }
        }
        public Book this[string name] //поиск книги по названию
        {
            get
            {
                foreach (Book book in books)
                {
                    if (book.Name == name)
                    {
                        return book;
                    }
                }
                throw new Exception("Book not found by the name.");
            }
        }
        public Book this[string author, int year] //поиск книги по автору и году издания
        {
            get
            {
                foreach (Book book in books)
                {
                    if (book.Year == year && book.Author == author)
                    {
                        return book;
                    }
                }
                throw new Exception("Book not found by the author and the year.");
            }
        }
        public override string ToString()
        {
            return books.ToString();
        }
        public BookList AddBook(Book book) //Добавление книги
        {
            books.Add(book);
            return this;
        }
        public BookList RemoveBook(Book book) //Удаление книги
        {
            books.Remove(book);
            return this;
        }
        public static BookList operator+(BookList bookList, Book book)
        {
            bookList.AddBook(book);
            return bookList;
        }
        public static BookList operator-(BookList bookList, Book book)
        {
            bookList.RemoveBook(book);
            return bookList;
        }
    }
}