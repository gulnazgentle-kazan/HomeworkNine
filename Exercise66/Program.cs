/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите числот M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());


int SumNum(int m, int n)
{
    if (m == n + 1) return 0;
    return (m + SumNum(m + 1, n));

}


Console.WriteLine($"{SumNum(M, N)}");