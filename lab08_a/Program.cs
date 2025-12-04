int a = CorrectInput("a");
int b = CorrectInput("b");
int c = CorrectInput("c");
int pr = a * b * c;
Console.Write($"Произведение равно {pr}");

static int CorrectInput(string name)
{
    while (true)
    {
        Console.Write($"Введите число {name} больше двух: ");
        string num_str = Console.ReadLine()!;
        bool parsed = int.TryParse(num_str, out int res);
        if (!parsed)
        {
            Console.WriteLine("Напоминание, что надо ввести число!");
            continue;
        }
        if (res <= 2)
        {
            Console.WriteLine("Число должно быть больше двух!");
            continue;
        }
        return res;
    }
}
