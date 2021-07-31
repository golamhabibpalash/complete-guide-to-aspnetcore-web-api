using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models.ViewModels;
using my_books.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }
        [HttpGet("get-all-merit-student")]
        public IActionResult GetAllMeritStudent()
        {
            var stu = _booksService.GetAllBooks();
            return Ok(stu);
        }

        [HttpGet("get-student-by-id/{id}")]
        public IActionResult GetMeritStudentById(int id)
        {
            var stu = _booksService.GetById(id);
            return Ok(stu);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
