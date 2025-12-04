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

Functions.takeBook(books, "Анна Каренина");

Functions.showAllBooks(books);

Functions.giveBook(books, "абракадабра");
Functions.giveBook(books, "Анна Каренина");

class Book
{
    public required string name;
    public required int year;
    public required bool available;
}