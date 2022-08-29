// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.WriteLine("ВВедите трехзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = N / 10;
// int second = i % 10;

//      Console.WriteLine($"вторая цифра  {second} ");
   
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("ВВедите wифру, обозначающую день недели: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N == 6 | N == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else 
// {
//   Console.WriteLine("Рабочий");  
// }

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("ВВедите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//         while (n>=1000)
//     {
//         n = n / 10;
//     }
//     n = n % 10;
//     Console.WriteLine($"третья цифра {n}");
// }


// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("ВВедите пятизначное число число: ");
// int n = Convert.ToInt32(Console.ReadLine());

//         int a1 = n / 10000;
//         int a =  a1  % 10;
//         int b1 = n / 1000;
//         int b = b1 % 10;
//         int c1 = n / 10;
//         int c = c1 % 10;
//         int e = n % 10;

// if (a == e & b == c)
// {
//         Console.WriteLine($"палиндром");
// }
// else 
//     {
//         Console.WriteLine($"не палиндром");
//     }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


//    double length_otr(int a, int b, int c, int d, int e, int f)
   
//    {
//     double l = Math.Sqrt((a-d)*(a-d)+(b-e)*(b-e)+(c-f)*(c-f));
//     return l;
//    }

//     Console.WriteLine("ВВедите координату Х первой точки: ");
//     int Xa = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите координату Y первой точки: ");
//     int Ya = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите координату Z первой точки: ");
//     int Za = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите координату Х второй точки: ");
//     int Xb = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите координату Y второй точки: ");
//     int Yb = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите координату Z второй точки: ");
//     int Zb = Convert.ToInt32(Console.ReadLine());

// double length = length_otr(Xa, Ya, Za, Xb, Yb, Zb);
// Console.WriteLine($"Расстояние между точками {length}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("ВВедите число N: ");
// int N=int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.Write($"{i*i*i} ");
// } 

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.Write("ВВедите число A: ");
// int a=int.Parse(Console.ReadLine());
// Console.Write("ВВедите число B: ");
// int b=int.Parse(Console.ReadLine());


// int c = 1;
//     for (int i = 1; i <= b; i ++)
//     {
//         c = c * a;
//     }
    
// Console.WriteLine($"Число А в степени Б {(c)} ");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void sumDigits(int number)
// {
//     Console.Write($"sum all digits {number} = ");
//     int sum = 0;
//     while(number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     Console.Write($"{sum}");
// }

// sumDigits(9012);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] CreateRandomArray(int N, int start, int end)
// {
//        int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//     RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine("");
// }
// void EvenOne(int[] array1)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Kоличество чётных чисел в массиве {count}");
// }
// Console.WriteLine("Введите количество элементов массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("");
// EvenOne(myRandomArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] CreateRandomArray(int N, int start, int end)
// {
//        int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//     RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine("");
// }
// void Summa(int[] array1)
// {
//     int sum = 0;
//     for (int i = 0; i < array1.Length; i+=2)
//     {
                
//      sum = sum + array1[i];
        
//     }
//     Console.WriteLine($"сумму элементов, стоящих на нечётных позициях {sum}");
// }
// Console.WriteLine("Введите количество элементов массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int min = 0;
// int max = 9;

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("");
// Summa(myRandomArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int [] CreateRandomArray(int N, int start, int end)
// {
//        int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//     RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine("");
// }
// void Raz(int[] array1)
// {
//      int max1 = array1[0];
//      int min1 = array1[0];
//     for (int i = 0; i < array1.Length; i++)
//     {
           
//         if (array1[i] > max1)
//         {
//             max1 = array1[i];
//         }
//         if (array1[i] < min1)
//         {
//             min1 = array1[i];
//         }
        
//     }
//     int razn = max1 - min1;
//     Console.WriteLine($"разницу между максимальным и минимальным элементов массива {razn}");
// }
// Console.WriteLine("Введите количество элементов массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int min = 0;
// int max = 9;

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("");
// Raz(myRandomArray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// double[,] FillArray(int size, int k1, int b1, int k2, int b2, double x)
// {
//     double[,] array = new double[3, size + 1];
//     for (int i = 0; i <= size; i++)
//     {
//         array[0, i] = x + i * 0.01;
//         array[1, i] = k1 * (x + i * 0.01) + b1;
//         array[2, i] = k2 * (x + i * 0.01) + b2;
//     }
//     return array;
// }


// double YOfLine(double x, int k, int b)
// {
//     double y = k * x + b;
//     return y;
// }

// Console.Clear();
// Console.Write("Введите k для первой прямой: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  b для первой прямой: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  k для второй прямой: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b для второй прямой: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// if (k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
//     int minBorder = 0;
//     int maxBorder = 1;

//     double diffMin = YOfLine(minBorder, k1, b1) - YOfLine(minBorder, k2, b2);
//     double diffMax = YOfLine(maxBorder, k1, b1) - YOfLine(maxBorder, k2, b2);
//     Console.WriteLine($"{diffMin}, {diffMax}");

    
//     while ((diffMax * diffMin) > 0)
//     {
//         if (Math.Abs(diffMax) > Math.Abs(diffMin))
//         {
//             maxBorder = minBorder;
//             minBorder -= 1;
//         }
//         else
//         {
//             minBorder = maxBorder;
//             maxBorder += 1;
//         }
//         diffMin = YOfLine(minBorder, k1, b1) - YOfLine(minBorder, k2, b2);
//         diffMax = YOfLine(maxBorder, k1, b1) - YOfLine(maxBorder, k2, b2);
//     }

//        double[,] newArray = FillArray(100, k1, b1, k2, b2, minBorder);
//     double minValue = Math.Abs(newArray[1, 0] - newArray[2, 0]);
//     double[] crossPoint = {newArray[0, 0], newArray[1, 0]};
//     for (int i = 1; i < newArray.GetLength(1); i++)
//     {
//         if ((Math.Abs(newArray[1, i] - newArray[2, i])) < minValue)
//         {
//             crossPoint[0] = newArray[0, i];
//             crossPoint[1] = newArray[1, i];
//             minValue = Math.Abs(newArray[1, i] - newArray[2, i]);
//         }
//     }

//     Console.WriteLine($"Координаты точки пересечения: ({crossPoint[0]:f2}, {crossPoint[1]:f2})");
//     Console.WriteLine();

    
//     Console.WriteLine("Проверка координат точки пересечения математическим методом:");
//     double xCrossPoint = (double)(b2 - b1) / (k1 - k2);
//     Console.WriteLine($"X = {xCrossPoint}, Y = {YOfLine(xCrossPoint, k2, b2)}");
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("ВВедите числа через пробел: ");
int [] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0-> {GetCountPositiveElements(numbers)}");
Console.WriteLine();

int [] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item>0) count++;
    }
    return count;
}