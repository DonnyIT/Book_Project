using Book_Project.Models;

namespace Book_Project.Services
{
    public class BookService : IBookService
    {
        private List<Book> _books = BookList.Books;

        public IEnumerable<Book> GetBook()
        {
            return _books;
        }
        
        public Book? GetBookById(int id)
        {
            return _books.FirstOrDefault(book => book.Id == id);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Year = book.Year;
            }
        }

        public void DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(book => book.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }


        // Refactoring code
        public Book? GetBookByTitle(string title)
        {
            return _books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public Book? GetBookByYear(int year)
        {
            return _books.FirstOrDefault(book => book.Year == year);
        }

        public Book? GetBookByAuthor(string author)
        {
            return _books.FirstOrDefault(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
        }
    }
}
