// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] GetRandomArray (int size, int LeftRange, int RightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange +1);
    }
    return array;
}

int [] massive = GetRandomArray(10, 1, 100);
Console.WriteLine("Сгенерирован массив из 10 элементов, в диапазоне от 1 до 100.");

int max = 0;
int min = 101;

Console.WriteLine(string.Join(", ", massive));

for (int i = 0; i < massive.Length; i++)    
{        
    if (massive[i] > max)
    {
        max = massive[i];
    }
    if (massive[i] < min)
    {
        min = massive[i];
    }
}

Console.WriteLine("Максимальный элемент массива равен: " + max  + "\nМиниимальный элемент массива равен: " + min 
                    + "\nРазница между максимальным и минимальным элементами массива равна : " + (max - min));