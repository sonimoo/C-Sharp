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
}

class Book
{
    public required string name;
    public required int year;
    public required bool available;
}
