// See https://aka.ms/new-console-template for more information

using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore;
using Services;

Console.WriteLine("Hello, World!");

var bookService = new BookManager();

var books = new List<Book>()
{
    new Book
    {
        Id = 0,
        Title = "asd",
        Price = 15
    },
    new Book
    {
        Id = 0,
        Title = "dsa",
        Price = 55
    }
};

bookService.CreateBooks(books);

foreach (var allBook in bookService.GetAllBooks())
{
    Console.WriteLine(allBook.Title);
}

void CreateBook(Book book)
{
    var bookService = new BookManager();
    bookService.CreateBook(book);
}

void DeleteBook(Book book)
{
    var bookService = new BookManager();
    bookService.DeleteBook(book);
}