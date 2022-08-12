int count = 1;
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

while ( count <= a)
{
    if(count % 2 == 0)
    {
    Console.WriteLine(count);
    count = count + 1;
    }
    else
    {
    count = count + 1;
    }
}