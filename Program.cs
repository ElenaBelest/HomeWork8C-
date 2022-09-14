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
            // case 52: AverageColumns
            //(); break;
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



void OrderArray ()
{
    Console.Clear();

    Console.Write("Enter number of rows: \t");

    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter number of columns:\t");
    int column = int.Parse(Console.ReadLine());

    int [,] array = new int [row,column];

    GetRandomArray(array);
    PrintArray(array);

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    { 
        for (int n = 0; n < array.GetLength(1)-1; n++)

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
    

void GetRandomArray(int [,] array)
{
    for (int rows = 0; rows  < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows,columns] = new Random().Next(10,100);
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
            Console.Write(array[i,j] + " ");
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
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter column:\t");
    int column = int.Parse(Console.ReadLine());

    int [,] array = new int[row,column];

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
    Console.WriteLine("\n A row with the minimum sum of elements " + (minSum+1));


}

int SumRows(int [,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;

}

void PrintSum(int [,] array)
{
    Console.WriteLine();
      for (int i = 0; i < array.GetLength(0); i++)
     {
          int sum = 0;
          for (int j = 0; j < array.GetLength(1);j++)
          {
             sum = sum + array[i,j];
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

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
