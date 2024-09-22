using Book_Project.Services;

namespace Book_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Реєстрація сервісів у контейнері
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddControllers();

            var app = builder.Build(); // Тільки після реєстрації служб викликаємо Build()

            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllers();

            app.Run();
        }
    }
}
