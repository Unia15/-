//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Write("Введите колличество элементов массива: ");
int element = int.Parse(Console.ReadLine());
int[] mass=new int [element];
for(int i=0; i<mass.Length; i++)
{
System.Console.WriteLine("Введите элемент массива: ");
 mass[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
for(int i=0; i<mass.Length; i++)
{
 Console.Write(mass[i]+",");
}