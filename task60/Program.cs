// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Сформируем трехмерный массив");
Console.WriteLine("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите С: ");
int c = Convert.ToInt32(Console.ReadLine());

int d = a * b * c;

int[] array = new int[d];
int[,,] matrix = new int[a, b, c];


void Mas(int[]massiv)
{
   for (int i = 0; i < massiv.Length; i++)
   {
        massiv[i] = new Random().Next(10, 100);
        int M = massiv[i];
            for (int j = i-1; j >=0; j--)
            {
                 if (M == massiv[j])
                 {
                    i--;
                    break;
                 }
            }
      
    }
}

void ConvertMatrix(int[,,] matrix)
{
    int z = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {   
                matrix[i, j, k] =  array[z]; 
                z++;
            }
        }
        
    }
}

void PrintArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
        }
    }
}

Mas(array);
ConvertMatrix(matrix);
PrintArray(matrix);
