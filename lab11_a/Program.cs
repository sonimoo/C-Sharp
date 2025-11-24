using System.Diagnostics;

Colors color = Colors.red;

for (int i = 0; i < 6; i++)
{
    Actions act = GetAction(color);
    DoAction(act);
    color = NextState(color); 
    Console.WriteLine();
}

static Actions GetAction(Colors color)
{
    switch (color)
    {
        case Colors.green:
            return Actions.go;
        case Colors.red:
            return Actions.stop;
        case Colors.yellow:
            return Actions.wait;
        default:
            Debug.Fail("Неизвестный цвет светофора!");
            return Actions.stop;
    }
}

static void DoAction(Actions act)
{
    switch (act)
    {
        case Actions.go:
            Console.WriteLine("Действие - ехать");
            break;
        case Actions.stop:
            Console.WriteLine("Действие - ждать");
            break;
        case Actions.wait:
            Console.WriteLine("Действие - готовиться");
            break;
        default:
            Debug.Fail("Неизвестное действие!");
            break;
    }
}

static Colors NextState(Colors color)
{
    color++;
    if (color > Colors.last)
        color = Colors.first;
    return color;
}

enum Colors
{
    red,
    yellow,
    green,
    last = green,
first = red,
}

enum Actions
{
    go,
    wait,
    stop,
}
