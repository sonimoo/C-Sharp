void first()
{
    int a = 5;
    int b = 6;
    a = b;
    b = 7;
    Console.WriteLine(a);
}
first();

void second()
{
    int a = 5;
    int b = a + 6;
    a = 7;
    Console.WriteLine(b);
}
second();

void sed()
{
    string a = "a";
    string b = a;
    a = "b";
    Console.WriteLine(a);
}  
sed(); 

void fouth()
{
    //string a = 5; The build failed. Fix the build errors and run again. :)
}
  
fouth();