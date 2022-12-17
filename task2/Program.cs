// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());
int[,] array2d = new int[m,n];
 Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = rnd.Next(0, 10);
    }
}    
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
Console.WriteLine();   
}    
 int minRowSum = int.MaxValue, indexMinRow = 0;
for (int i = 0; i < m; i++)
{
    int rowSum = 0;
    for (int j = 0; j < n; j++)
    {
        rowSum += array2d[i, j];
    }        
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
for(int j = 0; j < n; j++)
{
    Console.Write(array2d[indexMinRow, j] + " ");  
}                 
    
             