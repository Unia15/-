//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] massiv = new int[3,4];
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);

double sum1 = (massiv[0,0] + massiv[1,0] + massiv[2,0]) / 3.0;
double sum2 = (massiv[0,1] + massiv[1,1] + massiv[2,1]) / 3.0;
double sum3 = (massiv[0,2] + massiv[1,2] + massiv[2,2]) / 3.0;
double sum4 = (massiv[0,3] + massiv[1,3] + massiv[2,3]) / 3.0;

void PrintArray(int[,] massiv1)
{
    for (int i = 0; i < massiv1.GetLength(0); i++)
    {
        for (int j = 0; j < massiv1.GetLength(1); j++)
        {
            Console.Write($"{massiv1[i, j]} ");
        }
    Console.WriteLine(); 
    }
}

void FillArray(int[,] massiv1)
{
    for (int i = 0; i < massiv1.GetLength(0); i++)
    {
        for (int j = 0; j < massiv1.GetLength(1); j++)
        {
            massiv1[i, j] = new Random().Next(1,10);
        }
    }
}

Console.Write($"{sum1:0.#}; {sum2:0.#}; {sum3:0.#}; {sum4:0.#}");
