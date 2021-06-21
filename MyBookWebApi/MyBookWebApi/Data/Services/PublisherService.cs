using Microsoft.EntityFrameworkCore;
using MyBookWebApi.Data.Models;
using MyBookWebApi.Data.Paging;
using MyBookWebApi.Data.ViewModels;
using MyBookWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBookWebApi.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        public Publisher AddPublisher(PublisherVM publisher)
        {
            if (StringStartWithNumber(publisher.Name)) throw new PublisherNameException("Name starts with number...", publisher.Name);
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publisher.Add(_publisher);
            _context.SaveChanges();
            return _publisher;
        }
        public Publisher GetPublisherById(int id) => _context.Publisher.FirstOrDefault(p => p.Id == id);
        public PublisherWithBooksAndAuthorsVM GetPublisherDataById(int publisherId)
        {
            var _publisherData = _context.Publisher.Where(n => n.Id == publisherId)
                .Select(n => new PublisherWithBooksAndAuthorsVM()
                {
                    Name = n.Name,
                    BooksAndAuthors = n.Books.Select(n => new BooksAuthorsVM()
                    {
                        BookName = n.Title,
                        BookAuthors = n.BookAuthors.Select(n => n.Author.FullName).ToList()
                    }).ToList()
                }).FirstOrDefault();
            return _publisherData;
        }

        public async Task<List<Publisher>> GetAllPublishers(string sortBy,string searchString,int? pageNumber)
        {
            var allPublisher =await _context.Publisher.OrderBy(p=>p.Name).ToListAsync();

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "name_desc":
                        allPublisher = allPublisher.OrderByDescending(p => p.Name).ToList();
                        break;
                    default:
                        break;
                }
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                allPublisher = allPublisher.Where(p => p.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }

            int pageSize = 5;
            allPublisher = PaginatedList<Publisher>.Create(allPublisher.AsQueryable(), pageNumber ?? 1, pageSize);

            return allPublisher;
        }

        public void DeletePublisherById(int id)
        {
            var publisher = _context.Publisher.FirstOrDefault(n=>n.Id==id);
            if (publisher != null)
            {
                _context.Publisher.Remove(publisher);
                _context.SaveChanges();
            }

        }
        private bool StringStartWithNumber(string name)=>(Regex.IsMatch(name, @"^\d")) ;
    }
}
