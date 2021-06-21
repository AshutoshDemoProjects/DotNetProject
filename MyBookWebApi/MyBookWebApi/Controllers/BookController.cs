using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookWebApi.Data.Services;
using MyBookWebApi.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookService _bookService;
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }
        
        
        [HttpGet("")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }

        [HttpPost("")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBookById(int id,[FromBody] BookVM book)
        {
            var dbBook = _bookService.UpdateBookById(id, book);
            return Ok(dbBook);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _bookService.DeleteBookById(id);
            return Ok();
        }
    }
}
