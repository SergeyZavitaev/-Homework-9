Random rd = new Random();

int M = 0;
int N = 0;

void GiveIntMandN()
{
    Console.WriteLine("Введите 2 натуральных числа");
    M = Convert.ToInt32(Console.ReadLine());
    N = Convert.ToInt32(Console.ReadLine());
}

//Задача 64: Задайте значения M и N.
//Напишите программу, которая выведет
//все натуральные числа в промежутке
//от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

string SequenceSegmentRec(int M, int N)
{
    if (N == M - 1) return "";
    return SequenceSegmentRec(M, N - 1) + Convert.ToString(N) + ", ";
}

//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке
//от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

string SumSequenceSegment(int M, int N, int sum = 1)
{
    if (N == M - 1) return Convert.ToString(sum - 1);
    sum = sum + N;
    return SumSequenceSegment(M, N - 1, sum);
}

//Задача 68: Напишите программу
//вычисления функции Аккермана
//с помощью рекурсии. Даны два
//неотрицательных числа m и n.
//m = 3, n = 2->A(m, n) = 29

string AckermannFunction(int M, int N)
{
    if (M == 0) { return Convert.ToString(N+1); }
    if (M>0 & N==0) { return AckermannFunction(M - 1, 1); }
    if (M > 0 & N > 0)
    { //Console.WriteLine(", m- " + M + ":,n-" + N);
        return AckermannFunction(M - 1,
        Convert.ToInt32(AckermannFunction(M, N - 1)) ); 
    }
    else { return "-1"; }
}

try
{
    Console.WriteLine("Задача 64:");
    GiveIntMandN();
    Console.WriteLine(SequenceSegmentRec(M, N));
    Console.WriteLine("Задача 66:");
    GiveIntMandN();
    Console.WriteLine(SumSequenceSegment(M, N));
    Console.WriteLine("Задача 68:");
    GiveIntMandN();
    Console.WriteLine(AckermannFunction(M, N));
}
catch
{
    Console.Write("Надо было вводить числа");
}