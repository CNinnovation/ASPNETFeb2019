using BooksLibrary.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary.Services
{
    public class BooksService
    {
        private readonly ConcurrentDictionary<int, Book> _books =
            new ConcurrentDictionary<int, Book>(
                new[]
                {
                    new KeyValuePair<int, Book>(1, new Book { BookId = 1, Title = "One", Publisher = "One" }),
                   new KeyValuePair<int, Book>(2, new Book { BookId = 2, Title = "Two", Publisher = "One" })
                });

        public IEnumerable<Book> GetBooks() => _books.Values;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBookById(int id) => _books[id];

        public void AddBook(Book book)
        {
            _books.AddOrUpdate(book.BookId, book, (id, b) =>
            {
                return b;
            });
        }

        public void DeleteBook(Book book)
        {
            _books.Remove(book.BookId, out _);
        }
    }
}
