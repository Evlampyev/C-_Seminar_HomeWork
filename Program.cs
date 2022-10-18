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
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Задача №10

int SecondDig(int num)
{
    int result = num / 10 % 10;
    return result;
}

int number = new Random().Next(100,1000);
int SecondDigit = SecondDig(number);
Console.WriteLine ($"Second digit of {number} is {SecondDigit}");

Задача №13

int ThirdDig(int num)
{
    int tri = -1;
    if (num > 99)
    {
        while (num > 999)
            num = num / 10;
        tri = num % 10;
    }    
    return tri;
}

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDig(number);
if (result == -1)
    Console.WriteLine("There is no such figure");
else
    Console.WriteLine($"The third figure is {result}");


    Задача №15

string DayWeek (int Day)
    {
        if (Day == 6 || Day ==7)
            return "Yes";
        else
            return "No";
    }


Console.Write("Input Day of week ");
int den = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayWeek(den));
 */
 