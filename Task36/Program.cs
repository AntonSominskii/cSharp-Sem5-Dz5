// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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

int sum = 0;
int iCounter = 0;
Console.WriteLine(string.Join(", ", massive) + "\nЭлементы на нечётных позициях массива:");

for (int i = 0; i < massive.Length; i++)    
{        
    if ((i+1) % 2 == 1) // Если я все правильно понял нужны нечетные порядковые номера, а не индексы. 
    {
        Console.WriteLine("Значение " + (i + 1) + "-го элемента массива: " + massive[i]);
        sum += massive[i];
        iCounter++;
    }
}

Console.WriteLine("Сумма " + iCounter + " элемента(ов) массива, стоящих на нечётных позициях: " + sum);