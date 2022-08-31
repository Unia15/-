//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int massiv;

Console.WriteLine("Введите размер квадратного массива:");
massiv = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massiv, massiv];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int summaminimum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int summa = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        summa = summa + numbers[i, j];        
    }
    if (summa < summaminimum)
    {
        summaminimum = summa;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером " + (indexLine) + ", сумма елементов: " + (summaminimum));



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            array[i, m] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[i, m] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}