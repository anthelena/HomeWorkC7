// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Ведите число столбцов m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число строк n ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int[m, n];
int [,] array2d2 = new int[m, n];
int [] array = new int [n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i,j]=random.Next (1,10);
        Console.Write(array2d[i,j]+" ");
        array[j]=array2d[i,j];
    }
    Console.WriteLine();
    Array.Sort(array);Array.Reverse(array);
    for (int j = 0; j < array.Length; j++)
    {
        array2d2[i,j]=array[j];
    }
} 
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2d2[i,j] + " ");    
    }
    Console.WriteLine();
}
