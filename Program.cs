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

Console.WriteLine("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
        while (n>=1000)
    {
        n = n / 10;
    }
    n = n % 10;
    Console.WriteLine($"третья цифра {n}");
}
