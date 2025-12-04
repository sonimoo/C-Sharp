Console.WriteLine("Введите число");
int num = 0;
while (true)
{
    string num_str = Console.ReadLine()!;
    bool num_parsed = int.TryParse(num_str, out num);
    if (!num_parsed)
    {
        Console.WriteLine("нужно ввести число!!!");
        continue;
    }
    break;
}
NumberFun(num);

static void NumberFun(int num)
{
    if (num < 0)
        Console.WriteLine("отрицательное число");
    else if (num == 0)
        Console.WriteLine("это ноль");
    else
        Console.WriteLine("это пололжительное число");
}