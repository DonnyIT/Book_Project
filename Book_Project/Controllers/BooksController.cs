using Book_Project.Models;
using Book_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Book_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookService? _bookService;

        //Refactoring code
        private ILogger<BooksController> _logger;
        //-----------------

        public BooksController(IBookService? bookService, ILogger<BooksController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get()
        {
            _logger.LogInformation("Fetching all books");
            var request = HttpContext.Request;
            Console.WriteLine(request.Path);
            var books = _bookService?.GetBook();
            return Json(books);
        }

        [HttpGet("search/{id}")]
        public JsonResult GetBookById(int id)
        {
            _logger.LogInformation($"Searching for book with id: {id}");
            var book = _bookService?.GetBookById(id);
            if (book != null)
            {
                return Json(book);
            }
            _logger.LogWarning($"Book with id '{id}' not found.");
            return Json(new { message = "Book not found" });
        }
        [HttpPost]
        public JsonResult AddBook(Book book)
        {
            _logger.LogInformation($"Add book {book.Title}");
            _bookService?.AddBook(book);
            _logger.LogInformation($"Book added successfully: {book.Title}");

            return Json(new { message = $"Book added successfully: {book.Title}"});
        }

        [HttpDelete("{id}")]
        public JsonResult DeleteBook(int id)
        {
            var book = _bookService?.GetBookById(id);
            if (book != null)
            {
                _logger.LogInformation($"Deleting book with ID: {id}, Title: {book.Title}");
                _bookService?.DeleteBook(id);
                _logger.LogInformation($"Book deleted successfully: \"{book.Title}\", {book.Author}, ({book.Year})");
                return Json(new { message = $"Book deleted successfully: {book.Title}" });
            }
            _logger.LogWarning($"Book with ID: {id} not found!");
            return Json(new { message = "Book not found!" });
        }

        [HttpPut("{id}")]
        public JsonResult UpdateBook(int id, [FromBody] Book book)
        {
            var existingBook = _bookService?.GetBookById(id);
            if (existingBook != null)
            {
                _logger.LogInformation($"Updating book with ID: {id}");
                book.Id = id;
                _bookService?.UpdateBook(book);
                _logger.LogInformation($"Book updated successfully: \"{book.Title}\", {book.Author}, ({book.Year})");
                return Json(new { message = $"Book updated successfully: {book.Title}" });
            }
            _logger.LogWarning($"Book with ID '{id}' not found.");
            return Json(new { message = "Book not found" });
        }


        // Refactoring code
        [HttpGet("search/author/{author}")]
        public JsonResult GetBookByAuthor(string author)
        {
            _logger.LogInformation($"Searching for book with title: {author}");
            var book = _bookService?.GetBookByAuthor(author);
            if (book != null && !string.IsNullOrEmpty(book.Author))
            {
                return Json(book);
            }
            _logger.LogWarning($"Book with author '{author}' not found.");
            return Json(new { message = "Book not found" });
        }

        [HttpGet("search/title/{title}")]
        public JsonResult GetBookByTitle(string title)
        {
            _logger.LogInformation($"Searching for book with title: {title}");
            var book = _bookService?.GetBookByTitle(title);
            if (book != null && !string.IsNullOrEmpty(book.Title))
            {
                return Json(book);
            }
            _logger.LogWarning($"Book with title '{title}' not found.");
            return Json(new { message = "Book not found" });
        }

        [HttpGet("search/year/{year}")]
        public JsonResult GetBookByYear(int year)
        {
            _logger.LogInformation($"Searching for book with year: {year}");
            var book = _bookService?.GetBookByYear(year);
            if (book != null)
            {
                return Json(book);
            }
            _logger.LogWarning($"Book with year '{year}' not found.");
            return Json(new { message = "Book not found" });
        }
    }
}
