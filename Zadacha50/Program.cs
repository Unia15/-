//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
int m;
int n;

Console.WriteLine("Введите размеры массива");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (1, 10);
        Console.Write (array[i,j] +"\t  ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введит элемент: ");
int row = Convert.ToInt32 (Console.ReadLine());
int a;
a = 999;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(array[i,j] == row)
        {
            a = array[i,j];
            break;
        }
    }
}
if(a != 999)
{
    Console.WriteLine("такое число есть");
}else
{
    Console.WriteLine("такого числа в массиве нет");
}
