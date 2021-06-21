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
    public class AuthorController : ControllerBase
    {
        private AuthorService _authorService;
        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("")]
        public IActionResult AddBook([FormBody] AuthorVM author)
        {
            _authorService.AddAuthor(author);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthorWithBooksById(int id)
        {
            var author=_authorService.GetAuthorWithBooks(id);
            return Ok(author);
        }
    }
}
