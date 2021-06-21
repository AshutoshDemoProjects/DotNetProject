using System.Collections.Generic;

namespace MyBookWebApi.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }
    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BooksAuthorsVM> BooksAndAuthors { get; set; }
    }
    public class BooksAuthorsVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}