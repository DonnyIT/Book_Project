using Book_Project.Models;

namespace Book_Project.Services
{
    public static class BookList
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851 },
            new Book { Id = 5, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 },
            new Book { Id = 6, Title = "War and Peace", Author = "Leo Tolstoy", Year = 1869 },
            new Book { Id = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 },
            new Book { Id = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 },
            new Book { Id = 9, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866 },
            new Book { Id = 10, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932 }
        };
    }
}
