Random rd = new Random();

Console.WriteLine("DZ zadacha 2:");
int input1 = 0;
int input2 = 0;
System.Console.WriteLine(input1 = rd.Next(1, 100));
System.Console.WriteLine(input2 = rd.Next(1, 100));
if (input1 > input2)
{
    System.Console.WriteLine($"max = {input1}");

}
else
{
    System.Console.WriteLine($"max = {input2}");
}

Console.WriteLine("DZ zadacha 4:");
int input3 = 0;
System.Console.WriteLine(input1 = rd.Next(1, 100));
System.Console.WriteLine(input2 = rd.Next(1, 100));
System.Console.WriteLine(input3 = rd.Next(1, 100));
if (input1 > input2 & input1 > input3)
{
    System.Console.WriteLine($"max = {input1}");
}
if (input2 > input1 & input2 > input3)
{
    System.Console.WriteLine($"max = {input2}");
}
if (input3 > input1 & input3 > input2)
{
    System.Console.WriteLine($"max = {input3}");
}

Console.WriteLine("DZ zadacha 6:");
int input = 0;
System.Console.WriteLine(input = rd.Next(-10, 11));
if (input % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}

Console.WriteLine("DZ zadacha 8:");
input = rd.Next(1,100);
int count = (input / 2);
for (int index = 1; index < count + 1; index++)
{
    Console.Write($"{index * 2}, ");
}