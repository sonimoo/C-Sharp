// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!"); //statement -инструкция
Console.WriteLine("Today is good day!");
Thread.Sleep(1000);
Console.WriteLine("I hope(");

Console.ReadKey();

Console.WriteLine("Hello, Jerry");
MethodABC();
Thread.Sleep(500);
MethodABC();
Thread.Sleep(500);
MethodABC();
Thread.Sleep(500);
Console.WriteLine("*  *  *");
FunctionA();
FunctionA();

void MethodABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void FunctionA()
{
    Console.WriteLine("Function A");
    FunctionB();
    FunctionC();
}

void FunctionB()
{
    Console.WriteLine("Function B");
}

void FunctionC()
{
    Console.WriteLine("Function C");
}
