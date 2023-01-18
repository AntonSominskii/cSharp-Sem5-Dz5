// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRandomArray (int size, int LeftRange, int RightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange +1);
    }
    return array;
}

int [] massive = GetRandomArray(10, 100, 999);
Console.WriteLine("Сгенерирован массив из 10 элементов, в диапазоне от 100 до 999.");
Console.WriteLine(string.Join(", ", massive) + "\nЧетные числа массива:");

int iCounter = 0;

for (int i = 0; i < massive.Length; i++)    
{        
    if (massive[i] % 2 != 1)
    {
        Console.WriteLine("Значение " + (i + 1) + "-го элемента массива: " + massive[i]); // Выводит порядковый номмер элемента массива.
        iCounter++;
    }
}

Console.WriteLine("Kоличество чётных чисел в массиве: " + iCounter);