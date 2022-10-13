/*
Урок 1

Задача №2

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine ($"max = {num1}");
else
    Console.WriteLine($"max = {num2}");


Задача №4

Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number " );
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
    num1 = num2;
if (num1 < num3)
    num1 = num3;
Console.WriteLine($"Max = {num1}");


Задача №6

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("ДА");
else
    Console.WriteLine("НЕТ");

Задача №8


int N = 0;
while (N < 2)
{
    Console.WriteLine("Input N >= 2 ");
    N = Convert.ToInt32(Console.ReadLine());
}
int current = 2;
while (current <= N)
{
    Console.Write(current + " ");
    current += 2;
}

*/