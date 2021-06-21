using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBookWebApi.Data;
using MyBookWebApi.Data.Models;
using MyBookWebApi.Data.Services;
using MyBookWebApi.Data.ViewModels;
using MyBookWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private PublisherService _service;
        private readonly ILogger<PublisherController> _logger;
        public PublisherController(PublisherService service, ILogger<PublisherController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpPost("")]
        public IActionResult AddPublisher([FormBody] PublisherVM publisher)
        {
            try
            {
                _logger.LogInformation("This is dummy logging...");
                var _publisher = _service.AddPublisher(publisher);
                return Created(nameof(AddPublisher), _publisher);
            }
            catch (PublisherNameException ex)
            {
                return BadRequest($"{ex.Message}, publisher name: {ex.PublisherName}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllPublisher(string sortBy,string searchString,int pageNumber)
        {
            try
            {
            var result = await _service.GetAllPublishers(sortBy,searchString,pageNumber);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}")]
        public ActionResult<Publisher> GetPublisherById(int id)
        {
            var publisher = _service.GetPublisherById(id);
            if (publisher != null)
                return publisher;
                //return Ok(publisher);
            else
                return NotFound();
        }
        [HttpGet("withBooksAndAuthors/{id}")]
        public IActionResult GetPublisherDataById(int id)
        {
            var publisher = _service.GetPublisherDataById(id);
            return Ok(publisher);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            try
            {
                _service.DeletePublisherById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
