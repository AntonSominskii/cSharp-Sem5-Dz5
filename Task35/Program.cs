// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] GetRandomArray (int size, int LeftRange, int RightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange +1);
    }
    return array;
}

int [] massive = GetRandomArray(123, 0, 1000);
Console.WriteLine("Сгенерирован массив из 123 элементов, в диапазоне от 0 до 1000.");
Console.WriteLine(string.Join(", ", massive) + "\nЭлементы массива в отрезке от 10 до 99:");

int iCounter = 0;

for (int i = 0; i < massive.Length; i++)    
{        
    if (massive[i] >= 10 && massive[i] <= 99)
    {
        Console.WriteLine("Значение " + (i + 1) + "-го элемента массива: " + massive[i]); // Выводит порядковый номмер элемента массива вместе с элементом.
        iCounter++;
    }
}

Console.WriteLine("Kоличество элементов массива, значения которых лежат в отрезке [10,99]: " + iCounter);