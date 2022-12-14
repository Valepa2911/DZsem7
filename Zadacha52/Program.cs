//Задайте двумерный массив (вручную) из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размер матрицы");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[x, y];
//int W = mas.GetLength(0);
//int Q = mas.GetLength(1);
Console.WriteLine("Введите числа для столбцов и для строк через Enter");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        mas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write(mas[i, j] + "|");
    }
    Console.WriteLine();
}


for (int i = 0; i < x; i++)
{
    double sum = 0;
    for (int j = 0; j < y; j++)
    {
        sum += mas[j, i];
    }
    Console.WriteLine("Сумма столбца {1}", i, sum/y);
}