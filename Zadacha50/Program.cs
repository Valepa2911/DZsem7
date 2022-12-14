// Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или же указание, 
//что такого элемента нет. 
//Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите число из массива: ");
var n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[,] { { 21, 33, 15, 65, -98, 41 }, { 65, 36, 30, 15, -42, 74 } };
Console.WriteLine(String.Join(" | ", array2d.Cast<int>()));
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        if (n == array2d[i, j])
        {
             Console.Write($"{i},{j} " + " ");
        }
        else
        {
            Console.Write("-" + " ");
        }
    }
}
