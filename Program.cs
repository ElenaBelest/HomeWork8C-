Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("54) Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("56) Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("58) Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("60) Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("62) Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 54: OrderArray(); break;
            case 56: MinSumRows(); break;
            case 58: ProductOfArrays(); break;
            case 60: Array3DOutput(); break;
            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



void OrderArray()
{
    Console.Clear();

    Console.Write("Enter number of rows: \t");

    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number of columns:\t");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[row, column];

    GetRandomArray(array);
    PrintArray(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)

                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
        }
    }
    Console.WriteLine();
    PrintArray(array);
}


void GetRandomArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine();
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumRows()
{
    Console.Clear();

    Console.Write("Enter row: \t");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter column:\t");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[row, column];

    GetRandomArray(array);
    PrintArray(array);
    PrintSum(array);


    int minSum = 0;

    int sum = SumRows(array, 0);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = SumRows(array, i);
        if (sum > temp)
        {
            sum = temp;
            minSum = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("\n A row with the minimum sum of elements " + (minSum + 1));


}

int SumRows(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;

}

void PrintSum(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        Console.Write(sum);
        Console.Write(" ");
    }
    return;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ProductOfArrays()
{
    Console.Clear();

    Console.Write("Enter row: \t");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter column:\t");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[row, column];
    int[,] array2 = new int[row, column];

    GetRandomArray(array);
    GetRandomArray(array2);
    PrintArray(array);
    PrintArray(array2);

    int [,] array3 = new int[row, column];

    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
     {
        int sum = 0;
        for (int n = 0; n < array.GetLength(1); n++)
        {
           sum = sum + (array[i,n] * array2[n,j]);
        }
        array3 [i,j]= sum;
     }   
    }
    PrintArray(array3);
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Array3DOutput()
{
    Console.Clear();

    Console.Write("Enter first number: \t");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number:\t");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter third number:\t");
    int number3 = Convert.ToInt32(Console.ReadLine());

    int [,,] array = new int[number1,number2,number3];

    GetRandomArray3D(array);
    PrintArray3D(array);

}

// void GetRandomArray3D(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 array[i, j, k] = new Random().Next(10, 100);
//         
//         }
//     }
// }

void GetRandomArray3D(int[,,] array)

{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    {
      for (int j = 0; j < i; j++)
      {
        if (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10,100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int k = 0; k < array.GetLength(0); k++)
  {
    for (int n = 0; n < array.GetLength(1); n++)
    {
      for (int m = 0; m < array.GetLength(2); m++)
      {
        array[k, n, m] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray3D(int[,,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
