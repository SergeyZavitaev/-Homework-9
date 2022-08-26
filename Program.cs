Random rd = new Random();

/////Задача 19/////
string palindrom5x()
{
    int input;
    Console.WriteLine(input = rd.Next(10000, 100000));

    //Console.WriteLine(input / 10000 == input % 10);
    if (input / 10000 == input % 10 &
        (input / 1000) % 10 == (input % 100) / 10)
    {
        return("Да");
    }
    else
    {
        return("Нет");
    }
}

try
{
    Console.WriteLine("Zadacha 19");
    Console.WriteLine(palindrom5x());
}
catch
{
    Console.Write("Надо было вводить числа");
}

/////Задача 21/////
double Distance3d()
{
    double[] coords = new double[6];
    double giveOtvetDoub(string message)
    {
        Console.Write(message);
        return Convert.ToDouble(Console.ReadLine());
    }
    coords[0] = giveOtvetDoub("Введите координату x ");
    coords[1] = giveOtvetDoub("Введите координату y ");
    coords[2] = giveOtvetDoub("Введите координату z ");
    coords[3] = giveOtvetDoub("Введите координату x ");
    coords[4] = giveOtvetDoub("Введите координату y ");
    coords[5] = giveOtvetDoub("Введите координату z ");
    double res = Math.Sqrt(
        (coords[0] - coords[3]) * (coords[0] - coords[3])
        + (coords[1] - coords[4]) * (coords[1] - coords[4])
        + (coords[2] - coords[5]) * (coords[2] - coords[5]));
    return res;
}

try
{
    Console.WriteLine("Zadacha 21");
    Console.WriteLine(Distance3d());
}
catch
{
    Console.WriteLine("Надо было вводить числа");
}

/////Задача 23/////
void SquareTableN()
{
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] answer = new int[N];
    if (N > 0)
    {
        for (int i = 1; i < (N + 1); i++)
        {
            answer[i - 1] = (i * i * i);
        }
    }
    else
    {
        Console.WriteLine("Надо было вводить положительные числа");
    }
    var str = string.Join(" ", answer);
    Console.WriteLine(str);
}

try
{
    Console.WriteLine("Zadacha 23");
    SquareTableN();
}
catch
{
    Console.WriteLine("Надо было вводить числа");
}

/////Задача необязательная/////
void SquareTableWithSumma()
{
    double summa=0; //переменная для цикла по вводу чисел и сложения квадратов из листа
    List<double> NumbersList = new List<double>();
    //Создать лист из double для хранения квадратов
    bool firstStart = true; //переменная для первого старта цикла
    while (summa != 0 || firstStart==true) //проверить сумму или сделать первый старт
    {
        if (firstStart == true) { firstStart = false; } //закрытие возможности для ложных первых стартов
        NumbersList.Add(Convert.ToDouble(Console.ReadLine())); //Добавить в лист число
        summa += NumbersList[NumbersList.Count - 1]; 
        //Добавить число к сумме из листа
        NumbersList[NumbersList.Count - 1]=
            NumbersList[NumbersList.Count - 1] *
            NumbersList[NumbersList.Count - 1]; 
        //Сделать квадрат числа из листа
    }
    for (int i = 0; i < NumbersList.Count; i++) //цикл для создания суммы всех квадратов
    {
        summa += NumbersList[i];
    }
    Console.WriteLine(summa);
}

try
{
    Console.WriteLine("Задача необязательная");
    SquareTableWithSumma();
}
catch
{
    Console.Write("Надо было вводить числа");
}