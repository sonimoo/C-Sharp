class Program
{
    static void Main(string[] args)
    {
        Library library = new Library(
            new Book[]
            {
                new Book()
                {
                    name = "Анна Каренина",
                    year = 1876,
                    available = true,
                    author = "Лев Толстой"
                },
                new Book()
                {
                    name = "Преступление и наказание",
                    year = 1900,
                    available = true,
                    author = "Фёдор Достоевский"
                },
                new Book()
                {
                    name = "бла бла бла",
                    year = 1000,
                    available = true,
                    author = "я (в прошлой жизни)"
                }
            }
        );

        library.takeBook("Анна Каренина");

        library.showAllBooks();

        library.giveBook("абракадабра");
        library.giveBook("Анна Каренина");
    }
}
