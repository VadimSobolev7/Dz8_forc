// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse
    (Console.ReadLine());
}

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int size = InputInt("Введите размер матрицы: ");
int[,] matrA = new int[size, size];
int[,] matrB = new int[size, size];
RandomArray(matrA);
RandomArray(matrB);
int[,] matrC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrC[i, j] = matrC[i, j] + (matrA[i, k] * matrB[k, j]);
        }
    }
}
Console.WriteLine("Матрица А");
PrintArray(matrA);
Console.WriteLine();
Console.WriteLine("Матрица В");
PrintArray(matrB);
Console.WriteLine();
Console.WriteLine("Произведение матриц ");
PrintArray(matrC);
