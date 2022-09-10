Random rd = new Random();

//Задача 41: Пользователь вводит
//с клавиатуры M чисел. Посчитайте
//, сколько чисел больше 0
//ввёл пользователь.
//5
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
void Mchisel()
{
    List<int> ListOfElements = new List<int>();
    int input = 0;

    bool stopGive = false; //переменная, которая сообщает нужно ли ещё сортировать или готово
    while (stopGive == false) //цикл пока не отсортирует
    {
        try
        {
            Console.Write("");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {
                ListOfElements.Add(input);
            }
        }
        catch
        {
            string inputStr = Console.ReadLine();
            if (inputStr == "")
            {
                stopGive = true;
            }
        }
    }

    int[] massive = ListOfElements.ToArray();
    for (int i = 0; i < massive.Length; i++)
    {
         massive[i] = rd.Next(100, 1000);
         Console.Write($"{massive[i]}, ");
    }
    Console.WriteLine($"-> {ListOfElements.Count}");
}

//Задача 43: Напишите программу,
//которая найдёт точку пересечения
//двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

void TwoLinesCrossing()
{
    double[] coords = new double[6];
    double giveOtvetDoub(string message)
    {
        Console.Write(message);
        return Convert.ToDouble(Console.ReadLine());
    }
    coords[0] = giveOtvetDoub("Введите координату b1: "); //b1
    coords[1] = giveOtvetDoub("Введите координату k1: "); //k1
    coords[2] = giveOtvetDoub("Введите координату b2: "); //b2
    coords[3] = giveOtvetDoub("Введите координату k2: "); //k2

    coords[4] = -1 * ((coords[0] - coords[2]) / (coords[1] - coords[3]));
    coords[5] = -1 * (coords[1]*( -1 * coords[4]) - coords[0]);

    Console.Write(coords[4].ToString());
    Console.Write(coords[5].ToString());
    int input = 0;
}
try
{
    Console.WriteLine("Задача 41: ");
    Mchisel();
    Console.WriteLine("Задача 43: ");
    TwoLinesCrossing();
}
catch
{
    Console.Write("Надо было вводить числа");
}