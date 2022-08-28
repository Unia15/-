//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

  int Sum(int a)
  {
    int count = Convert.ToString(a).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = a - a % 10;
      result = result + (a - advance);
      a = a / 10;
    }
   return result;
  }

int sum = Sum(a);
Console.WriteLine("Сумма цифр в числе: " + sum);