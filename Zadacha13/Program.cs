// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int a;

Console.Write("Введи число: ");
a = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(a);
   if (Number.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Number[2]);
}
  else 
{
  Console.WriteLine("-> третьей цифры нет");
}
