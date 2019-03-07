using BooksLibrary.Models;
using BooksLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BooksLibrary.Controllers
{
    [Route("api/[controller]")]
    [Produces()]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly BooksService _booksService;
        public BooksController(BooksService booksService, ILogger<BooksController> logger)
        {
            _booksService = booksService;
            _logger = logger;
            // var logger1 = factory.CreateLogger<BooksController>();

           
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Ok(_booksService.GetBooks().ToArray());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = _booksService.GetBookById(id);
            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _booksService.AddBook(book);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = _booksService.GetBookById(id);
            _booksService.DeleteBook(book);
        }
    }
}
