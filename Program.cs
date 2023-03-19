//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] FillMatrixMassiv(int row, int column)
{
    double[,] matrix = new double[row,column];
    Random rnd = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.NextDouble()*10;
            matrix[i,j] = Math.Round(matrix[i,j],2);
        }
    }
return matrix;
}

void PrintMatrixMassiv(double[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Напишите число строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixMassiv(row, column);
PrintMatrixMassiv(matrix);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int[,] FillNewMatrixMassiv(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(-10,100);
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}



bool SearchElementMassivaMatrix(int[,] matrix, int number)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(matrix[i,j]==number)
            {
                Console.WriteLine($"Ура число {number} есть в массиве в {i+1} строчке и {j+1} столбце");
                return true;
            }            
            
        }
    }
    Console.WriteLine($"Число отсутствует ");
    return false;
}

void SearchNumberMassivaMatrix(int[,] matrix, int rownumber, int colummnumber)
{
    if (rownumber < 0 | rownumber > matrix.GetLength(0) | colummnumber < 0 | colummnumber > matrix.GetLength(1))
    {
    Console.WriteLine("Элемент не существует  ");
    }
        else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[rownumber, colummnumber]);
    }
}

Console.Write("Напишите количество строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите количество столбцов ");
int columm = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] matrix = FillNewMatrixMassiv(row,columm);
PrintMatrixMassiv(matrix);
Console.WriteLine();
Console.Write("Напишите элемент массива ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("_______________________");
SearchElementMassivaMatrix(matrix, number);
Console.WriteLine("***********************");
Console.WriteLine("Давайте, теперь найдем число по строчке и столбцу ");

Console.WriteLine("Напишите номер строчки ");
int rownumber = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Напишите номер столбца ");
int colummnumber = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("_______________________");
SearchNumberMassivaMatrix(matrix, rownumber, colummnumber);
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillNewMatrixMassiv(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(2,30);
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

void SummaRowMatrixMassiv(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumrow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        sumrow += matrix[i, j];
        }
        sumrow /= matrix.GetLength(0);
        sumrow = Math.Round(sumrow,2);
        Console.Write($"{ sumrow}\t ");
    }
}


Console.Write("напишите количество столбцов ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк ");
int columm = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillNewMatrixMassiv(row,columm);
PrintMatrixMassiv(matrix);

Console.WriteLine("---------------------------");
Console.WriteLine();
SummaRowMatrixMassiv(matrix);

