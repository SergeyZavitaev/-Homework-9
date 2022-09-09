Random rd = new Random();

//Задача 34: Задайте массив заполненный
//случайными положительными трёхзначными
//числами. Напишите программу, которая
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void countEvenNumbers(int count)
{
    int[] massive = new int[count];
    for (int i = 0; i < massive.Length; i++)
    {
         massive[i] = rd.Next(100, 1000);
         Console.Write($"{massive[i]}, ");
    }
    //Console.WriteLine("");
    int otvet = 0;
    for (int i = 0; i < count; i++)
    {
        if (massive[i] % 2==0)
        {
            otvet++;
        }
    }
    Console.WriteLine($"-> {otvet}");
}

//Задача 36: Задайте одномерный массив,
//заполненный случайными числами.
//Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

void summaNotEvenNumbers(int count)
{
    int[] massive = new int[count];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = rd.Next(-50, 100);
        Console.Write($"{massive[i]}, ");
    }
    
    int summa = 0;
    for (int i = -1; i < count; i++)
    {
        if (i % 2 == 0)
        {
            summa=summa+massive[i+1];
        }
    }
    Console.WriteLine($"-> {summa}");
}

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

void differenceMaxAndMin(int count)
{
    double[] massive = new double[count];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = rd.NextDouble()*1000;
        Console.Write($"{massive[i]} ");
    }

    //max
    double max = massive[0];
    int maxIndex = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > max)
        {
            max = massive[i];
            maxIndex = i;
        }
    }

    //min
    double min = massive[0];
    int minIndex = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < max)
        {
            min = massive[i];
            minIndex = i;
        }
    }

    Console.WriteLine($"-> {max-min}");
}

try
{
    Console.WriteLine("Задача 34: ");
    countEvenNumbers(4);
    Console.WriteLine("Задача 36: ");
    summaNotEvenNumbers(4);
    Console.WriteLine("Задача 38: ");
    differenceMaxAndMin(5);
}
catch
{
    Console.Write("Надо было вводить числа");
}