Book[] books = new Book[3]
{
    new Book()
    {
        name = "Анна Каренина",
        year = 1876,
        available = true,
    },
    new Book()
    {
        name = "Преступление и наказание",
        year = 1900,
        available = true, 
    },
    new Book()
    {
        name = "бла бла бла",
        year = 1000,
        available = true, 
    }

};

static void takeBook(Book[] books, string name)
{
    foreach (Book book in books)
    {
        if (book.name == name)
        {
            if (book.available == true)
            {
                book.available = false;
            }
        }
    }
}

static void giveBook(Book[] books, string name)
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

static void showAllBooks(Book[] books)
{
    foreach (Book book in books)
    {
        Console.WriteLine($"{book.name}, {book.year}, доступна: {book.available}");
    }
}

takeBook(books, "Анна Каренина");

showAllBooks(books);

giveBook(books, "абракадабра");
giveBook(books, "Анна Каренина");

class Book
{
    public string name;
    public int year;
    public bool available;
}