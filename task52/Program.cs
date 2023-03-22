// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GetRandom (int rows, int columns, int left, int right)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(left, right+1);
       }
    }   
    return matrix;
}

void print (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix[i, j] + "  ");
        }
    Console.WriteLine();
    Console.WriteLine();
    }
}



void Result (int [,] matrix)
{
    int [,] matrix1 = matrix;
    for (int j = 0; j < matrix1.GetLength (0); j++) 
    {
        double sum = 0;
        for (int i = 0; i < matrix1.GetLength (0); i++) 
        {
        sum += matrix1[i, j];
        }
    sum /= matrix1.GetLength (1);
    Console.Write($" {sum}, ");
     }
}

const int ROWS = 4;
const int COLUMNS = 4;
const int LEFT = 1;
const int RIGHT = 5;
int [,] myMatrix = GetRandom (ROWS, COLUMNS, LEFT, RIGHT);
print (myMatrix);
Result(myMatrix);