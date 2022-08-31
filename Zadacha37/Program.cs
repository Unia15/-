//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

//Console.Write("Размер массива:");

Console.WriteLine("Введите размер массива");
var size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
for(int i=0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива");
    var arrayItem = Convert.ToInt32(Console.ReadLine());
    numbers[i] = arrayItem;
}

int[] result = new int[size/2 + 1];
for(int i=0; i < size; i++)
{
    int leftIndex = i;
    int rightIndex = size - i - 1;
    if(leftIndex > rightIndex)
    {
        break;
    }
    result[i] = numbers[leftIndex] * numbers[rightIndex];
}

Console.Write($"[{string.Join(' ', numbers)}] -> {string.Join(' ', result)}");








