// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

double [,] GetRandom (int rows, int columns)
{
    double [,] matrix = new double [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = (Random.Shared.NextDouble() *10) -1;
        double c = matrix[i, j];
        c = Math.Round(c, 1);
        matrix[i, j] = c;
       }
    }   
    return matrix;
}

void print (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix[i, j] + "  ");
        }
    Console.WriteLine();
    }
}



const int ROWS = 4;
const int COLUMNS = 6;
double [,] myMatrix = GetRandom (ROWS, COLUMNS);
print (myMatrix);