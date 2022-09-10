Random rd = new Random();

//Задача 47. Задайте двумерный массив
//размером m×n, заполненный случайными
//вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9

void CreateAndPrint2dMassive()
{
    Console.WriteLine("Введите количество строк двумерного массива ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] FillArray(int m, int n)
    {
        double[,] array = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.NextDouble()*(100-0);
            }
        }
        return array;

    }
    void PrintArray(double[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    double[,] mas = FillArray(m, n);
    PrintArray(mas);
}

//Задача 50.Напишите программу,
//которая на вход принимает позиции
//элемента в двумерном массиве, и
//возвращает значение этого элемента
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

void ThereElementPositionInMassive()
{
    //Console.WriteLine("Введите количество строк двумерного массива ");
    int m = 3;//Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = 4;//Convert.ToInt32(Console.ReadLine());

    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.Next(100, 1000);
            }
        }
        return array;

    }
    void TestArray(int[,] table)
    {
        List<int> NumbersList = new List<int>();
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                NumbersList.Add(table[i, j]);
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Write("Введите позицию: ");
        int TestIndex = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine($" -> {NumbersList[TestIndex-1]}");
        }
        catch
        {
            Console.WriteLine(" -> такого числа в массиве нет");
        }
    }
    int[,] massive = FillArray(m, n);
    TestArray(massive);
}

//Задача 52.Задайте двумерный
//массив из целых чисел.
//Найдите среднее арифметическое
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца:
//4,6; 5,6; 3,6; 3.

void AverageOfColumn()
{
    int m = 3;
    int n = 3;

    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.Next(100, 1000);
            }
        }
        return array;

    }
    void PrintArray(int[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    void AverageArraysColumns(int[,] table)
    {
        List<double> NumbersList = new List<double>();
        double summa = 0;
        for (int j = 0; j < table.GetLength(1); j++) //j это строки
        {
            for (int i = 0; i < table.GetLength(0); i++) //i это столбцы
            {
                summa += (table[i, j]);
            }
            NumbersList.Add(summa / table.GetLength(1));
            summa = 0;
        }
        var str = string.Join(", ", NumbersList.ToArray());
        Console.WriteLine($"Среднее арифметическое каждого столбца: {str}");
    }
    int[,] massive = FillArray(m, n);
    PrintArray(massive);
    AverageArraysColumns(massive);
}

try
{
    Console.WriteLine("Задача 47: ");
    CreateAndPrint2dMassive();
    Console.WriteLine("Задача 50: ");
    ThereElementPositionInMassive();
    Console.WriteLine("Задача 52: ");
    AverageOfColumn();
}
catch
{
    Console.Write("Надо было вводить числа");
}