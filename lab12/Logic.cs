class Library
{
    private List<Book> freeBooks;
    private List<Book> takenBooks;

    public Library(Book[] books)
    {
        freeBooks = new List<Book>(books);
        takenBooks = new List<Book>();
    }
    
    public void takeBook(string name)
    {
        foreach (Book book in freeBooks)
        {
            if (book.name == name)
            {
                freeBooks.Remove(book);
                takenBooks.Add(book);
                book.available = false;
                return;
            }
        }

        Console.WriteLine("Книги то нет -_-");
    }
    
    public void giveBook(string name)
    {
        foreach (Book book in takenBooks)
        {
            if (book.name == name)
            {
                takenBooks.Remove(book);
                freeBooks.Add(book);
                book.available = true;
                return;
            } 
        }
        
        Console.WriteLine("Такой книги не было!!");
    }

    public void showAllBooks()
    {
        Console.WriteLine("Свободные книги: ");
        foreach (Book book in freeBooks)
        {
            Console.WriteLine($"{book.name}, {book.year}, доступна : {book.available} хотя зачем она ж в списке свободных");
        }
        Console.WriteLine("Не свободные книги: ");
        foreach (Book book in takenBooks)
        {
            Console.WriteLine($"{book.name}, {book.year}, доступна : {book.available} хотя зачем");
        }
    }

    public void FilteredBooks(LibraryFilter filter)
    {
        List<Book> allBooks = new List<Book>();
        allBooks.AddRange(freeBooks);
        allBooks.AddRange(takenBooks);

        foreach (Book book in allBooks)
        {
            // 1) Проверяем состояние
            if (filter.State == BookState.Free && !book.available)
                continue; 
            if (filter.State == BookState.Taken && book.available)
                continue; 

            // 2) Проверяем содержание строки в имени
            if (filter.NameContains != null && !book.name.Contains(filter.NameContains))
                continue;

            // 3) Проверяем что строки нет в имени
            if (filter.NameNotContains != null && book.name.Contains(filter.NameNotContains))
                continue;

            // 4) Проверяем автора
            if (filter.Author != null && book.author != filter.Author)
                continue;

            // 5) Проверяем начало имени
            if (filter.NameStartsWith != null && !book.name.StartsWith(filter.NameStartsWith))
                continue;

            Console.WriteLine($"{book.name}, {book.author}, {book.year}, доступна: {book.available}");
        }
    }
}

class Book
{
    public required string name;
    public required int year;
    public required bool available;
    public required string author;
}

enum BookState
{
    Taken,
    Free,
    Any
}