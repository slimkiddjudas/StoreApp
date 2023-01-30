using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore;
using Services.Contracts;

namespace Services
{
    public class BookManager : IBookService
    {
        private RepositoryContext _context;

        public BookManager()
        {
            _context = new RepositoryContext();
        }

        public void CreateBook(Book book)
        {
            var addedBook = _context.Entry(book);
            addedBook.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void CreateBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                CreateBook(book);
            }
        }

        public List<Book> GetBooksAsc(int n)
        {
            var booksAsc = GetAllBooks().OrderBy(b => b.Id);
            return booksAsc.Take(n).ToList();
        }

        public void UpdateBook(int id, Book book)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == id);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Price = book.Price;
                var updatedBook = _context.Entry(bookToUpdate);
                updatedBook.State = EntityState.Modified;
            }

            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books;
        }

        public void DeleteBook(Book book)
        {
            var deletedBook = _context.Entry(book);
            deletedBook.State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
