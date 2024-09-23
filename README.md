# Book Management API
___
## Опис

**Book Management API** — це просте REST API для управління книгами, побудоване на платформі ASP.NET Core. Додаток підтримує CRUD операції (створення, отримання, оновлення та видалення книг) та включає можливість пошуку книг за різними параметрами (назва, автор, рік випуску). Логування операцій також реалізовано для зручності відстеження дій.

## Функціонал

API забезпечує наступний функціонал:
- **Отримання всіх книг**: Отримання повного списку книг.
- **Пошук книги за ID**: Пошук книги за її унікальним ідентифікатором.
- **Пошук книги за назвою**: Пошук книги за її назвою.
- **Пошук книги за автором**: Пошук книги за іменем автора.
- **Пошук книги за роком**: Пошук книги за роком випуску.
- **Додавання нової книги**: Додавання нової книги до колекції.
- **Оновлення інформації про книгу**: Оновлення інформації про існуючу книгу.
- **Видалення книги**: Видалення книги за її ID.

## Використані технології

- **ASP.NET Core 6.0**: Основна платформа для розробки API.
- **ILogger**: Інструмент для логування дій (додавання, оновлення, видалення книг).
- **In-memory storage**: Дані книг зберігаються у пам'яті додатку за допомогою колекції `List<Book>`.

## Вимоги

- **.NET SDK 6.0** або новіший.
- **Postman**: Для тестування API запитів.
____

## Інструкції з встановлення та запуску

1. Клонуйте репозиторій:
   ```bash
   git clone https://github.com/yourusername/BookManagementAPI.git
2. Встановіть залежності та збудуйте проект:
   ```bash
   dotnet restore
   dotnet build
3. Запустіть проект:
   ```bash
   dotnet run
4. API буде доступне за адресою:
   ```bash
    http://localhost:5000/api/books/
   
## Тестування з використанням Postman
1. Запустіть Postman.
2. Створіть новий запит (Request).
3. Використовуйте відповідні HTTP-методи (GET, POST, PUT, DELETE) та маршрути, наведені нижче.
4. Для POST та PUT запитів вкажіть тіло запиту у форматі JSON.

## Маршрути API
1. **Отримати всі книги**
  ```bash
    GET /api/books
  ```
2. **Отримати книгу за ID**
  ```bash
    GET /api/books/search/{id}
  ```
3. **Пошук книги за назвою**
  ```bash
    GET /api/books/search/title/{title}
  ```
***Приклад:***
  ```bash
    GET /api/books/search/title/The Hobbit
  ```
4. **Пошук книги за автором**
  ```bash
    GET /api/books/search/author/{author}
  ```
***Приклад***:
  ```bash
    GET /api/books/search/author/J.R.R. Tolkien
  ```

5. **Пошук книги за роком**
  ```bash
    GET /api/books/search/year/{year}
  ```
***Приклад:***
  ```bash
    GET /api/books/search/year/1937
  ```
6. **Додавання нової книги**
  ```bash
  POST /api/books/
  ```
***Тіло запиту (у форматі JSON):***
  ```json
  {
    "title": "New Book",
    "author": "Author Name",
    "year": 2024
  }
  ```
7. **Оновлення книги**
  ```bash
    PUT /api/books/{id}
  ```
***Тіло запиту (у форматі JSON):***
  ```json
  {
    "title": "Updated Book",
    "author": "Updated Author",
    "year": 2025
  }
  ```
8. **Видалення книги**
  ```bash
    DELETE /api/books/{id}
  ```
___
## Логування
### API використовує систему логування для відстеження основних операцій, таких як додавання, оновлення та видалення книг. Логи записуються за допомогою сервісу ILogger.
**Приклад логів:**
  ```plaintext
  info: Book_Project.Controllers.BooksController[0]
        Fetching all books
  info: Book_Project.Controllers.BooksController[0]
        Adding book: The Great Gatsby
  info: Book_Project.Controllers.BooksController[0]
        Book added successfully: The Great Gatsby
  info: Book_Project.Controllers.BooksController[0]
        Deleting book with ID: 1, Title: The Great Gatsby
  info: Book_Project.Controllers.BooksController[0]
        Book deleted successfully: The Great Gatsby
  ```
___
## Ліцензія
### Цей проект поширюється під ліцензією MIT.



