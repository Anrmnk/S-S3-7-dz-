// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет


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

void main (int [,] matrix)
{
Console.Write ($" Введите индекс по строке ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write ($" Введите индекс по столбцу ");
int b = Convert.ToInt32 (Console.ReadLine ());
int [,] matrix1 = matrix;
for (int i = 0; i < matrix1.GetLength (0); i++) 
{
    for (int j = 0; j < matrix1.GetLength (1); j++)
    {
        if (i == a && j == b)
        {
            Console.WriteLine ($" {matrix1[i, j]} ");
            return;
        }
    }
}
Console.WriteLine ($" Tакого числа в массиве нет! :-( ");
}


const int ROWS = 4;
const int COLUMNS = 6;
const int LEFT = 1;
const int RIGHT = 15;
int [,] myMatrix = GetRandom (ROWS, COLUMNS, LEFT, RIGHT);
print (myMatrix);

main (myMatrix);