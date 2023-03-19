// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Задайте размерность матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[a, a];
int[,] matrixB = new int[a, a];
int[,] proizved = new int[a, a];



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4} ");
        Console.WriteLine();
    }
}


void ProizvAB(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                proizved[i, j] = proizved[i, j] + array1[i, k] * array2[k, j];
            }

        }
    }
    return;
}

Console.WriteLine("Матрица А:");
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица В:");
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();
ProizvAB(matrixA, matrixB);
Console.WriteLine("Произведение матриц А и В:");
PrintArray(proizved);