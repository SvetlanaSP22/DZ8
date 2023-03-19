// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите такое же количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

int minSumString = 0;
int sumString = SumStringElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumString = SumStringElements(array, i);
  if (sumString > tempSumString)
  {
    sumString = tempSumString;
    minSumString = i;
  }
}
// Console.WriteLine($"Номер строки с наименьшей суммой элементов ({sumString}) ");

int SumStringElements(int[,] array, int i)
{
  int sumString = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumString += array[i,j];
  }
  return sumString;
}

FillArray(array);
PrintArray(array);
SumStringElements(array, 0);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {sumString} строка ");

