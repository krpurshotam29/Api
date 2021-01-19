using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {

        public BooksController()
        {

        }

        // POST: api/books
        [HttpGet("")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        // Get: api/books/9
        [HttpGet("{id}")]
        public Book GetBook(int id)
        {
            return new Book()
            {
                Id = id
            };
        }

        // POST: api/books/add
        [HttpPost("add")]
        public int PostBook(Book book)
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }

        // PUT: api/books/7/update
        [HttpPut("{id}/update")]
        public bool UpdateBook(int id, Book book)
        {
            return true;
        }

        // Delete: api/books/4
        [HttpDelete("{id}")]
        public bool DeleteBook(int id)
        {
            return true;
        }

        // GET: api/books/search?name=BookName&publication=PublicationName&author=AuthorName
        [HttpGet("search")]
        public IEnumerable<Book> SearchBooks([FromQuery]string name = null, [FromQuery]string publication = null, [FromQuery]string author = null)
        {
            return (new List<Book>()).Where(book => (name != null && book.Name.ToLower().Contains(name.ToLower()))
                    || (publication != null && book.Publication.ToLower().Contains(publication.ToLower()))
                    || (author != null && book.Author.ToLower().Contains(author.ToLower())));
        }
    }
}
