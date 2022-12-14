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
