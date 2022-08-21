int a;

Console.WriteLine("Введите число");

a = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(a);

if (number[0]==number[4] || number[1]==number[3])
{
    Console.WriteLine($"{a} - палиндром");  
}
else
{
    Console.WriteLine($"{a} - не палиндром");
} 




