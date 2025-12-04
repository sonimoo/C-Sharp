static class Functions
{
    public static void takeBook(Book[] books, string name)
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

    public static void giveBook(Book[] books, string name)
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

    public static void showAllBooks(Book[] books)
    {
        foreach (Book book in books)
        {
            Console.WriteLine($"{book.name}, {book.year}, доступна: {book.available}");
        }
    }
}