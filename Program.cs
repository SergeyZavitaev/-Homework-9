Random rd = new Random();
int input;

//Zadacha 10:
Console.WriteLine("Zadacha 10");
Console.WriteLine(input = rd.Next(100, 1000));
input = (input / 10) % 10;
Console.WriteLine(input);

//Zadacha 13:
Console.WriteLine("Zadacha 13");
Console.WriteLine(input = rd.Next(1, 200));
if (input > 99)
{
    Console.WriteLine(input = (input / 100) % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}


//Zadacha 15
Console.WriteLine("Zadacha 15");
Console.WriteLine(input = rd.Next(-10, 11));
if (input > 5 || input < 8)
{
    Console.WriteLine("нет");
}
else
{
    if (input == 2 || input == 7) { Console.WriteLine("да"); }
}

//задача необязательная.
Console.WriteLine("задача необязательная.");
Console.WriteLine("Введите кол-во программистов: ");
int programmer_count = Convert.ToInt32(Console.ReadLine());
string end = "";
if (programmer_count % 10 > 1 & programmer_count % 10 < 5)
{
    end = "а";
}
if (programmer_count % 10 > 4 || programmer_count % 10 < 1
    || programmer_count % 100 > 10 & programmer_count % 100 < 21)
{
    end = "ов";
}
Console.Write($"{programmer_count} программист{end}");