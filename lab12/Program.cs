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
                },
                new Book()
                {
                    name = "The Great Gatsby",
                    year = 1925,
                    available = false,
                    author = "Fitzgerald"
                }
            }
        );

    library.takeBook("Анна Каренина");

    library.showAllBooks();

    library.giveBook("абракадабра");
    library.giveBook("Анна Каренина");

    var filter = ReadLibraryFilter();

    Console.WriteLine("Filter created!");
    Console.WriteLine($"Status = {filter.State}");
    Console.WriteLine($"NameContains = {filter.NameContains ?? "(null)"}");

    library.FilteredBooks(filter);

    }

    static LibraryFilter ReadLibraryFilter()
    {
        var filter = new LibraryFilter();
        var input = new InputLibraryFilter(filter);

        // 1) Status
        while (true)
        {
            Console.Write("Status (Free, Taken, Any): ");
            string? str = Console.ReadLine();

            if (!input.Status(str))
            {
                Console.WriteLine("Invalid input");
                continue;
            }
            break;
        }

        Console.Write("Name contains: ");
        input.NameContains(Console.ReadLine());

        Console.Write("Name NOT contains: ");
        input.NameNotContains(Console.ReadLine());

        Console.Write("Author: ");
        input.Author(Console.ReadLine());

        Console.Write("Name starts with: ");
        input.NameStartsWith(Console.ReadLine());

        return filter;
    }

}
