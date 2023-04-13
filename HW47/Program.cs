// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


int[ , ] CreateMatrixRandomInt(int rows,int columns, int min, int max)
{
                           //0     1
    int[,] matrix = new int[rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)  //matrix.GetLenght(0)
    {
        for (int j = 0; j < columns; j++)   //matrix.GetLenght(1)
        {
            matrix [i,j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" = ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine(" = ");
    }
}

int [,] array2d = CreateMatrixRandomInt(3,4,-10,10);
PrintMatrix(array2d);