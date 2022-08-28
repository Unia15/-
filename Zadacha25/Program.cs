//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int a;
int b;

Console.WriteLine("число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число b");
b = Convert.ToInt32(Console.ReadLine());

int number = a;
for (int i = 1; i < b; i++)
{
number = number * a;
}
Console.WriteLine("Ответ:" + number);
