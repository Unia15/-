int a;
int b;
int c;

Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());


if(a > b)
{
    if (a > c)
    {
        Console.WriteLine("{0} самое большое число", a);
    }
    else if (c > b)
    {
        Console.WriteLine("{0} самое большое число", c);
    }
    else
    {
        Console.WriteLine("{0} самое большое число", b);
    }
   
}
else if (b > a)
{
    if (b > c)
    {
        Console.WriteLine("{0} самое большое число", b);
    }
    else 
    {
        Console.WriteLine("{0} самое большое число", c);
    }
   
}