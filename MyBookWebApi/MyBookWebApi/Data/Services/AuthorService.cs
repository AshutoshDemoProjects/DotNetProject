using MyBookWebApi.Data.Models;
using MyBookWebApi.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;
        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };
            _context.Author.Add(_author);
            _context.SaveChanges();
        }
        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _authorWithBook = _context.Author.Where(n => n.Id == authorId).Select(a => new AuthorWithBooksVM() {
                FullName= a.FullName,
                booksName = a.BookAuthors.Select(ba=>ba.Book.Title).ToList()
            }).FirstOrDefault();
            return _authorWithBook;
        }
    }
}
