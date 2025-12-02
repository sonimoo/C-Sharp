class Library
{
    private Book[] books;

    public Library(Book[] books)
    {
        this.books = books;
    }
    
    public void takeBook(string name)
    {
        foreach (Book book in books)
        {
            if (book.name != name)
                continue;
            if (book.available == true)
            {
                book.available = false;
                return;
            }
        }
    }
    
    public void giveBook(string name)
    {
        foreach (Book book in books)
        {
            if (book.name == name)
            {
                book.available = true;
                return;
            } 
        }
        
        Console.WriteLine("Такой книги не было!!");
    }

    public void showAllBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine($"{book.name}, {book.year}, доступна: {book.available}");
        }
    }
}

class Book
{
    public required string name;
    public required int year;
    public required bool available;
}
