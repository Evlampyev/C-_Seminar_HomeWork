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
Console.WriteLine($"The sum of the digits of the number {number} = {SumOfDigits(number)}");


______________________________________________________________________________________
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* int[] InputArray (int size)
{
    int[] inputArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{i} element = ");
        inputArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return inputArray;

}

void PrintIntArrayArray(int [] massiv)
{
    Console.Write("Еhe entire array: ");
    for (int i = 0; i<massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
}

Console.Write("Enter the size of the array ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] mainArray = InputArray(arraySize);
PrintIntArrayArray(mainArray); 

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Семинар №5 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
______________________________________________________________________________________

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] СreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintIntArray(int[] array) // Вывод целого массива в троку
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SearchEvenNumbers(int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            current++;
        }
    }
    return current;
}

/* Console.Write("Input size ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Input LowLevel ");
int LowLevel = Convert.ToInt32(Console.ReadLine());
Console.Write("Input HiLevel ");
int HiLevel = Convert.ToInt32(Console.ReadLine()); */

/* int[] MainArray = СreatRandomArray(s, LowLevel, HiLevel);
PrintIntArray (MainArray);
Console.WriteLine ();
Console.WriteLine("Even array elements " + SearchEvenNumbers(MainArray));

______________________________________________________________________________________
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  

int SearchEvenIndex (int [] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 ==0) current ++;
    return current;
}

int NotSearchEvenIndex (int [] array)
{
    return (array.Length / 2) + (array.Length % 2);
}


int[] MainArray = СreatRandomArray(s, LowLevel, HiLevel);
PrintIntArray (MainArray);
Console.WriteLine ();

Console.WriteLine ("Elements found in even places " + SearchEvenIndex(MainArray));
Console.WriteLine ("Сalculated elements in even places " + NotSearchEvenIndex(MainArray));

______________________________________________________________________________________
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


double[] CreatRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() + new Random().Next(minValue, maxValue)), 4);
    }
    return array;
}

void PrintDoubleArray(double[] array) // Вывод на экран вещественного массива в одну строку
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double MaxElementArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double MinElementArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

/* ouble[] MainArray = CreatRandomDoubleArray (s, LowLevel, HiLevel);
PrintDoubleArray (MainArray);
Console.WriteLine ();
double Max = MaxElementArray(MainArray);
double Min =  MinElementArray(MainArray);
double Max_Min =  Max - Min;
Console.WriteLine($"The difference between the maximum({Max}) and minimum({Min}) element is {Max_Min}");
 */

/*  
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Семинар №6 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
______________________________________________________________________________________
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int HoWManyPositiveNumber(int k) //Количество положительных чисел из k вводимых с клавиатуры
{
    int current = 0;
    Console.WriteLine($"Input {k} Numbers: ");
    while (k > 0)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        k--;
        if (num > 0)
            current++;
    }
    return current;
}

/* Console.WriteLine("How much numbers ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Positie number - {HoWManyPositiveNumber(m)}"); 

______________________________________________________________________________________
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double IntersectionPoint(double k1, double b1, double k2, double b2) // Нахождение координаты X пересечения двух прямых
{
    return (b2 - b1) / (k1 - k2);

}

/* Console.Write("Input k1 ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1 ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2 ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 ");
double B2 = Convert.ToDouble(Console.ReadLine());

double x = IntersectionPoint(K1, B1, K2, B2);
double y = K1 * x + B1;
Console.WriteLine($"Intersection point x = {x} y = {y}"); 

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Семинар №7 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
______________________________________________________________________________________
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int[,] CreateRandomIntArray2d(int m, int n, int minValue, int maxValue) // Заполнение массива mxn целыми числами
{
    int[,] array2d = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array2d[i, j] = new Random().Next(minValue, maxValue + 1);
    return array2d;
}

double[,] CreateRandomArray2d(int m, int n, int minValue, int maxValue) //заполнение массива mxn вещественными числами
{
    double[,] array2d = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double temp = (new Random().NextDouble()) + (new Random().Next(minValue, maxValue));
            array2d[i, j] = Math.Round(temp, 1);
        }
    }
    return array2d;
}

void PrintIntArrayArray2d(double[,] array2d) // Вывод на экран двумерного вещественного массива
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FormatPrintDoubleArrayArray2d(double[,] array2d) //Форматный вывод на экран двумерного вещественного массива
{
    string s = string.Empty;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            s += String.Format("{0,5}", array2d[i, j]);
        }
        Console.WriteLine(s);
        s = string.Empty;
    }
}

void FormatPrintIntArrayIntArray2d(int[,] array2d) //Форматный вывод на экран двумерного целого массива
{
    string s = string.Empty;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            s += String.Format("{0,5}", array2d[i, j]);
        }
        Console.WriteLine(s);
        s = string.Empty;
    }
}

Console.Write("Input size m ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size n ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number ");
int maxV = Convert.ToInt32(Console.ReadLine());

/* double[,] mainArray2d = CreateRandomArray2d(row, col, minV, maxV);
PrintIntArrayArray2d(mainArray2d);
Console.WriteLine();
FormatPrintDoubleArrayArray2d(mainArray2d); */

/* ______________________________________________________________________________________
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет */

int SearchElement(int[,] array, int row, int col, int maxValue)// Поиск элемента array[row,col] в массиве
{
    if (row > array.GetLength(0) || col > array.GetLength(1))
        return maxValue + 1;
    else
        return array[row, col];
}

/* int[,] mainArray2d = CreateRandomIntArray2d(row, col, min, max);
FormatPrintIntArrayIntArray2d(mainArray2d);
Console.WriteLine("Input SearcRow ");
int searchRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input SearcCol ");
int searchCol = Convert.ToInt32(Console.ReadLine());
int search = SearchElement(mainArray2d, searchRow,searchCol, maxV);
if (search == max + 1)
    Console.WriteLine("There is no such element");
else
    Console.WriteLine(search);

______________________________________________________________________________________
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void ArithmeticMeanColumn(int[,] array) //Поиск среднего арифметического в столбце
{
    Console.Write("Arithmetic Mean of each Column: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp += array[i, j];
        }
        temp = Math.Round(temp / array.GetLength(0), 1);
        Console.Write(temp + "; ");
    }
}

/* int[,] mainArray2d = CreateRandomIntArray2d(row, col, min, max);
FormatPrintIntArrayIntArray2d(mainArray2d);
ArithmeticMeanColumn(mainArray2d);

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Семинар №8 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
______________________________________________________________________________________ 
 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void GetSortedArray(int[,] array) //Сортировка строк массива по убыванию
{
    int[] minIndex = new int[2];
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = array.GetLength(1); count > 1; count--)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j - 1] < array[i, j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                }
            }
        }
    }
}

int[,] mainArray = CreateRandomIntArray2d(row, col, minV, maxV);
FormatPrintIntArrayIntArray2d(mainArray);
/* GetSortedArray(mainArray);
Console.WriteLine();
FormatPrintIntArrayIntArray2d(mainArray); */

/*
______________________________________________________________________________________ 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int GetMinLineSum(int[,] array, int minSum) //Поиск номера строки с минимальной суммой элементов
{
    int sum;
    int line = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum) 
        {
            minSum = sum;
            line = i;
        }
    }
    return line;
}

int minLineSum = GetMinLineSum(mainArray, maxV * col);
Console.WriteLine($"Line with min sum is {minLineSum + 1}");