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

__________________________________________________________________________________

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
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
__________________________________________________________________________________
Задача №10

int SecondDig(int num)
{
    int result = num / 10 % 10;
    return result;
}

int number = new Random().Next(100,1000);
int SecondDigit = SecondDig(number);
Console.WriteLine ($"Second digit of {number} is {SecondDigit}");
__________________________________________________________________________________
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

__________________________________________________________________________________
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

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 _________________________________________________________________________________
  Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 

void polydrome(int num)
{
    bool answer = true;
    int AnotherNum = num;
    int count = 0;
    while (AnotherNum > 0)
    {
        AnotherNum = AnotherNum / 10;
        count = count + 1;
    }
 
    int degree = (int)Math.Pow(10, count-1);
    while (answer && num > 9)
    {
        int first = num / degree;
        int last = num % 10;
        if (first != last)
            {answer = false;}
        num = num - first*degree;
        num = num / 10;
        degree = degree / 100;
    }
    Console.WriteLine(answer);
    return;
}

Console.WriteLine("enter a five-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
polydrome(number);

______________________________________________________________________________________
Задача №21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distanse (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double first = Math.Pow((x1-x2),2);
    double second = Math.Pow((y1-y2),2);
    double third = Math.Pow((z1-z2),2);
    return Math.Sqrt(first + second + third);  
}

Console.WriteLine("Input x1 ");
double Xx1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1 ");
double Yy1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1 ");
double Zz1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x2 ");
double Xx2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2 ");
double Yy2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2 ");
double Zz2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distanse is {Math.Round(Distanse(Xx1, Yy1, Zz1, Xx2, Yy2, Zz2),2)}");

______________________________________________________________________________________
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void Cubes (int num)
{
    int count = 1;
    Console.Write(num + " -> ");
    while (count <= num)
    {
        Console.Write(Math.Pow(count,3) + " ");
        count ++;
    }
    return;
}

Console.WriteLine("Input Number ");
int number = Convert.ToInt32(Console.ReadLine());
Cubes(number);



++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Семинар №4 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
______________________________________________________________________________________
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 

int Level (int x, int y)
{
    int current = 1;
    for (int i = 1; i <= y; i++) current = current * x;
    return current;
}

Console.Write("Input number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input level of number ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} ^ {b} = {Level(a, b)}");

______________________________________________________________________________________
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits (int num)
{
    int result = 0;
    while (num > 0)
        {
            result += num % 10;
            num = num / 10;
        }
    return result;
}

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"the sum of the digits of the number {number} = {SumOfDigits(number)}");

