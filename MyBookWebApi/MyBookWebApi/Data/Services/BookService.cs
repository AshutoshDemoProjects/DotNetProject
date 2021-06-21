using MyBookWebApi.Data.Models;
using MyBookWebApi.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Data.Services
{
    public class BookService
    {
        private AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Discription = book.Discription,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate= book.Rate,
                Genre=book.Genre,
                CoverUrl=book.CoverUrl,
                DateAdded= DateTime.Now,
                PublisherId = book.PublisherId
            };
            _context.Book.Add(_book);
            _context.SaveChanges();

            foreach (var id in book.AuthorIds)
            {
                var bookAuthor = new BookAuthor()
                {
                    BookId = _book.Id,
                    AuthorId = id
                };
                _context.BookAuthor.Add(bookAuthor);
                _context.SaveChanges();
            }
        }

        public List<Book> GetAllBooks() => _context.Book.ToList();

        public BookWithAuthorVM GetBookById(int bookId)
        {
            var _bookWithAuthors = _context.Book.Where(b => b.Id == bookId).Select(book => new BookWithAuthorVM()
            {
                Title = book.Title,
                Discription = book.Discription,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genre = book.Genre,
                CoverUrl = book.CoverUrl,
                PublisherName = book.Publisher.Name,
                AuthorNames = book.BookAuthors.Select(n => n.Author.FullName).ToList()
            }).FirstOrDefault();
            return _bookWithAuthors;
        }

        public Book UpdateBookById(int id, BookVM book)
        {
            var _book = _context.Book.FirstOrDefault(b => b.Id == id);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Discription = book.Discription;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genre = book.Genre;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookById(int bookId)
        {
            var book = _context.Book.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                _context.Book.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
