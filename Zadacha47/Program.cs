﻿//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m;
int n;

Console.Write("Введите m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
n = Convert.ToInt32(Console.ReadLine());


double[,] array = new double[m, n];

CreateArrayDouble(array);
WriteArray(array);

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 10; 
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double Number = Math.Round(array[i, j], 1);
        Console.Write(Number + " ");
      }
      Console.WriteLine();
  }
}

