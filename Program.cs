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

Console.Write("ВВедите число N: ");
int N=int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write($"{i*i*i} ");
} 