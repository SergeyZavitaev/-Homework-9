Random rd = new Random();

//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит
//по убыванию элементы каждой строки
//двумерного массива.

void SortEveryString2dArray()
{
    Console.WriteLine("Введите количество строк двумерного массива ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.Next(-100,100);
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

    void Sort2dArray(int[,] arr)
    {
        for (int stringChanger = 0; stringChanger < arr.GetLength(0); stringChanger++){
            List<int> NumbersList = new List<int>();
            for (int ColumnsChanger = arr.GetLength(1) -1; ColumnsChanger > -1; ColumnsChanger = ColumnsChanger - 1)
            {
                NumbersList.Add(arr[stringChanger, ColumnsChanger]);
            }
            int[] massive = NumbersList.ToArray();
            bool sort = false; //переменная, которая сообщает нужно ли ещё сортировать или готово
            while (sort == false) //цикл пока не отсортирует
            {
                for (int i = 1; i < massive.Length; i++) //цикл на весь массив
                {
                    if (massive[i] > massive[i - 1]) //замена значений если одно больше другого от большего к меньшему
                    {
                        int newValue = massive[i - 1];
                        massive[i - 1] = massive[i];
                        massive[i] = newValue;
                    }
                }

                bool error = false; //переменная на проверки есть ли ошибки или готово
                for (int i = 1; i < massive.Length; i++) //цикл на массив
                {
                    if (massive[i] > massive[i - 1]) //проверка значений
                    {
                        error = true; // если ли есть проблемы, то ставим что ошибка есть
                    }
                }
                if (error == false) //если ошибок не найдено значит отсортировано
                {
                    sort = true;
                }
            }
            for (int ColumnsChanger = arr.GetLength(1) - 1;
                ColumnsChanger > -1; ColumnsChanger = ColumnsChanger - 1) //занесение результата в массив
            {
                arr[stringChanger, ColumnsChanger] = massive[ColumnsChanger];
            }
        }
    }

    int[,] mas = FillArray(m, n);
    PrintArray(mas);
    Sort2dArray(mas);
    PrintArray(mas);
}

//Задача 56: Задайте прямоугольный
//двумерный массив. Напишите программу,
//которая будет находить строку с
//наименьшей суммой элементов.

void PringMinSumString()
{
    Console.WriteLine("Введите количество строк двумерного массива ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.Next(-100, 100);
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

    void PrintMinString2dArray(int[,] arr)
    {
        int StringWithMinSum=0;
        int OldMinSum = 0;
        for (int stringChanger = 0; stringChanger < arr.GetLength(0); stringChanger++)
        {
            int MinSum = 0;
            for (int ColumnsChanger = arr.GetLength(1) - 1; ColumnsChanger > -1; ColumnsChanger = ColumnsChanger - 1)
            {
                MinSum=MinSum+(arr[stringChanger, ColumnsChanger]);
            }

            if (MinSum < OldMinSum)
            {
                //Console.WriteLine(MinSum);
                StringWithMinSum = stringChanger;
            }

            OldMinSum = MinSum;
        }
        Console.WriteLine($"{StringWithMinSum+1} строка");
    }

    int[,] mas = FillArray(m, n);
    PrintArray(mas);
    PrintMinString2dArray(mas);
}

//Задача 58: Задайте две матрицы.
//Напишите программу, которая будет
//находить произведение двух матриц.

void matrixMultiply()
{
    //Console.WriteLine("Введите количество строк двумерного массива ");
    int m = 2;//Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = 2;//Convert.ToInt32(Console.ReadLine());
    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rd.Next(-100, 100);
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

    int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
    {
        int[,] Matrix = new int[2, 2];
        Matrix[0, 0] = (arr1[0, 0]* arr2[0, 0])+(arr1[0,1]* arr2[1, 0]);
        Matrix[0,1] = (arr1[0, 0] * arr2[0, 1]) + (arr1[0, 1] * arr2[1, 1]);
        Matrix[1,0] = (arr1[1, 0] * arr2[0, 0]) + (arr1[1, 1] * arr2[1, 0]);
        Matrix[1,1] = (arr1[1, 0] * arr2[0, 1]) + (arr1[1, 1] * arr2[1, 1]);

        return Matrix;
    }

    int[,] mas1 = FillArray(m, n);
    //PrintArray(mas1);

    Console.WriteLine("");

    int[,] mas2 = FillArray(m, n);
    //PrintArray(mas2);

    mas1[0, 0] = 2; mas1[0, 1] = 4; 
    mas1[1, 0] = 3; mas1[1, 1] = 2;
    mas2[0, 0] = 3; mas2[0, 1] = 4; 
    mas2[1, 0] = 3; mas2[1, 1] = 3;
    PrintArray(mas1);
    PrintArray(mas2);

    Console.WriteLine("");

    PrintArray(MatrixMultiplication(mas1, mas2));
}

void PrintWithIndex3dArray()
{
    //Console.WriteLine("Введите количество строк двумерного массива ");
    int m = 2;//Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = 2;//Convert.ToInt32(Console.ReadLine());
    int k = 2;
    int[,,] FillArray(int m, int n, int k)
    {
        int[,,] array = new int[m, n, k];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int h = 0; h < k; h++)
                {
                    array[i, j, h] = rd.Next(-100, 100);
                }
            }
        }
        return array;

    }
    void PrintArray(int[,,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int h = 0; h < table.GetLength(2); h++)
                {
                    Console.Write($"{table[i, j, h]}({j},{h},{i}) ");
                }
                Console.WriteLine("");
            }
        }
    }
    int[,,] mas = FillArray(m, n, k);
    PrintArray(mas);
}

void FillSpiral4x4()
{
    //Console.WriteLine("Введите количество строк двумерного массива ");
    int m = 4;//Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Введите количество столбцов двумерного массива ");
    int n = 4;//Convert.ToInt32(Console.ReadLine());
    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = 0;// rd.Next(-100, 100);
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

    int[,] Spiral4x4(int[,] arr)
    {
        int rotator = 0; //0-right, 1-down, 2-left, 3-up, 4=0
        int x = 0; //x - [x,0] строки
        int y = -1; //y - [0,y] столбцы

        for (int n=1; n<arr.Length*2; n++)
        {
            if(rotator == 0)
            {
                if (y < (arr.GetLength(1))) //проверка можно ли идти в ту сторону
                {
                    try
                    {
                        if (arr[x, y + 1] == 0)
                        {
                            arr[x,y + 1] = n;
                            y++;
                        }
                        else
                        {
                            rotator = 1;
                        }
                    }
                    catch
                    {
                        rotator = 1;
                    }
                }
            }
            if (rotator == 1)
            {
                try
                {
                    if (arr[x+1, y] == 0)
                    {
                        arr[x + 1, y] = n;
                        x++;
                    }
                    else
                    {
                        rotator = 2;
                    }
                }
                catch
                {
                    rotator = 2;
                }
            }
            if (rotator == 2)
            {
                try
                {
                    if (arr[x, y - 1] == 0)
                    {
                        arr[x, y - 1] = n;
                        y = y - 1;
                    }
                    else
                    {
                        rotator = 3;
                    }
                }
                catch
                {
                    rotator = 3;
                }
            }
            if (rotator == 3)
            {
                try
                {
                    if (arr[x - 1, y] == 0)
                    {
                        arr[x - 1, y] = n;
                        x =x - 1;
                    }
                    else
                    {
                        rotator = 4; 
                    }
                }
                catch
                {
                    rotator = 4; 
                }
            }
            if (rotator == 4)
            {
                if (y < (arr.GetLength(1))) //проверка можно ли идти в ту сторону
                {
                    try
                    {
                        if (arr[x, y + 1] == 0)
                        {
                            arr[x, y + 1] = n;
                            y++;
                        }
                        else
                        {
                            rotator = 1;y = y - 1;n = n - 1;x++;
                        }
                    }
                    catch
                    {
                        rotator = 1;
                    }
                }
            }
        }

        return arr;
    }

    int[,] mas1 = FillArray(m, n);
    PrintArray(mas1);

    Console.WriteLine("");

    PrintArray(Spiral4x4(mas1));
}

try
{
    Console.WriteLine("Задача 54: ");
    SortEveryString2dArray();
    Console.WriteLine("Задача 56: ");
    PringMinSumString();
    Console.WriteLine("Задача 58: ");
    matrixMultiply();
    Console.WriteLine("Задача 60: ");
    PrintWithIndex3dArray();
    Console.WriteLine("Задача 62: ");
    FillSpiral4x4();
}
catch
{
    Console.Write("Надо было вводить числа");
}