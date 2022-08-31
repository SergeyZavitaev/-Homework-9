//Задача 25: Напишите цикл,
//который принимает на вход два числа
//(A и B) и возводит число A в
//натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16
Random rd = new Random();

int stepen()
{
    Console.Write("Введите число: ");
    int input1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: ");
    int input2 = Convert.ToInt32(Console.ReadLine());
    int otvet = 1;
    for (int i = 0; i < input2; i++)
    {
        otvet = otvet * input1;
    }
    return otvet;
}

//Задача 27: Напишите программу,
//которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int summaNumbers()
{
    Console.Write("Введите число: ");
    string str = Console.ReadLine();
    char[] array = str.ToCharArray();
    int summa = 0;
    foreach (char i in array)
    {
        summa += Convert.ToInt32(char.ToString(i));
    }
    return summa;
}

//Задача 29: Напишите программу,
//которая задаёт массив из 8
//элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

void createMassive(int count)
{
    int[] massive = new int[count];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = rd.Next(0, 100);
        Console.Write($"{massive[i]}, ");
    }
    Console.WriteLine("");
}

//необязательная задача Написать программу
//сортировки массива от большего к меньшему.
//Массив задается размерностью N с клавиатуры,
//далее заполняется случайными целыми числами.

void createMassiveAndSort()
{
    Console.Write("Введите число для установки размера массива: ");
    int N = Convert.ToInt32(Console.ReadLine()); //Получить N
    int[] massive = new int[N]; //создать массив размером N
    for (int i = 0; i < massive.Length; i++) // цикл на весь массив
    {
        massive[i] = rd.Next(0, 100); //заполнение случайным числом
        Console.Write($"{massive[i]}, "); //распечатка элемента массива
    }
    Console.WriteLine(""); //отступ так как там был write

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
    var str = string.Join(", ", massive); //распечатка массива
    Console.WriteLine(str);
}


try
{
    Console.WriteLine("Задача 25: ");
    Console.WriteLine(stepen());
    Console.WriteLine("Задача 27: ");
    Console.WriteLine(summaNumbers());
    Console.WriteLine("Задача 29: ");
    createMassive(8);
    Console.WriteLine("Задача необязательная: ");
    createMassiveAndSort();
}
catch
{
    Console.Write("Надо было вводить числа");
}