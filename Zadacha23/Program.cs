Console.WriteLine("Введите число");

int i = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= i; a++)
{
   Console.WriteLine($"{a}*{a}*{a} = {a*a*a}");
}