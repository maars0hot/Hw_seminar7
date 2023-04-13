// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет

Console.WriteLine("Введите позицию элемента для поиска:");
Console.WriteLine("Строка:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбец:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = CreateMatrixRandomInt(5,5,1,10);
PrintMatrix(newMatrix);
FindElement(newMatrix,m,n);

void FindElement (int[,] matrix,int findM,int findN)
{
    if (findM<matrix.GetLength(0) && findN<matrix.GetLength(1))
    {
        Console.WriteLine ($"Элемент равен {matrix[findM,findN]}");
    }
    else Console.WriteLine("Такого элемента нет");
}

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
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine(" | ");
    }
}
