// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] dddarray = new int[x, y, z];
CreateArray(dddarray);
WriteArray(dddarray);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] dddarray)
{
  for (int i = 0; i < dddarray.GetLength(0); i++)
  {
    for (int j = 0; j < dddarray.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < dddarray.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={dddarray[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] dddarray)
{
  int[] pow = new int[dddarray.GetLength(0) * dddarray.GetLength(1) * dddarray.GetLength(2)];
  int  number;
  for (int i = 0; i < pow.GetLength(0); i++)
  {
    pow[i] = new Random().Next(10, 100);
    number = pow[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (pow[i] == pow[j])
        {
          pow[i] = new Random().Next(10, 100);
          j = 0;
          number = pow[i];
        }
          number = pow[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < dddarray.GetLength(0); x++)
  {
    for (int y = 0; y < dddarray.GetLength(1); y++)
    {
      for (int z = 0; z < dddarray.GetLength(2); z++)
      {
        dddarray[x, y, z] = pow[count];
        count++;
      }
    }
  }
}

