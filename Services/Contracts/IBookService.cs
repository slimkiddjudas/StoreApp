using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Services.Contracts
{
    public interface IBookService
    {
        void CreateBook(Book book);
        void CreateBooks(IEnumerable<Book> books);
        List<Book> GetBooksAsc(int n);
        void UpdateBook(int id, Book book);
        IEnumerable<Book> GetAllBooks();
        void DeleteBook(Book book);
    }
}
