// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("***Задача 25***");
int Exponentiation(int a, int b)
{
    int x = 1;
    for (int i = 1; i <= b; i++)
    {
        x = x * a;
    }
    return x;
}
Console.Write("Введи число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(a, b);
Console.WriteLine("А в степени В = " + exponentiation);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("***Задача 27***");
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int tempHelp = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        tempHelp = number - number % 10;
        sum = sum + (number - tempHelp);
        number = number / 10;
    }
    return sum;
}
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе = " + sumNumber);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("***Задача 29***");
int[] array = new int[8] { 8, 9, 1, 2, 5, 7, 11, 5 };
Console.Write($"Массив:[{array[0]}, {array[1]}, {array[2]}," +
$" { array[3]}, { array[4]}, { array[5]}, " +
$"{ array[6]}, { array[7]}]");

