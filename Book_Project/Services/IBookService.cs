using Book_Project.Models;

namespace Book_Project.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBook(); // Метод для отримання всіх книг
        //Refactoring code
        Book? GetBookById(int id);     // Метод для отримання книги за Id
        Book? GetBookByTitle(string title); // Метод для отримання книги за Title
        Book? GetBookByAuthor(string author); // Метод для отримання книги за Author
        Book? GetBookByYear(int year); // Метод для отримання книги за Year
        //-------------
        void AddBook(Book book);      // Метод для додавання нової книги
        public void UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}
