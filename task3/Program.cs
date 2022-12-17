// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите данные первой матрицы: ");
int [,] Matrix1 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
Random random = new Random();
Console.WriteLine("Первая матрица: ");
for (int i = 0; i < Matrix1.GetLength(0); i++)
{
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            Matrix1[i,j] = random.Next (0,10);
            Console.Write(Matrix1[i,j] + " "); 
        }
         Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите данные второй матрицы: ");
int [,] Matrix2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < Matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            Matrix2[i,j] = random.Next (0,10);
            Console.Write(Matrix2[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
if (Matrix1.GetLength(1) != Matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
    Environment.Exit(0);
}
int [,] Matrix2new = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
for (int i = 0; i < Matrix1.GetLength(0); i++)
{
    for (int j = 0; j < Matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < Matrix2.GetLength(0); k++)
        {
            Matrix2new[i,j] += Matrix1[i,k] * Matrix2[k,j];
        }
    }
}
Console.WriteLine("Результат: ");
for (int i = 0; i < Matrix2new.GetLength(0); i++)
{
    for (int j = 0; j < Matrix2new.GetLength(1); j++)
    {
    Console.Write(Matrix2new[i,j] + " ");
    }
Console.WriteLine();
}

