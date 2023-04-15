Console.Write("Введите размерность m массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void Matrix(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
            Console.Write($"{ randomArray[i, j]} ");
}
Console.WriteLine();
}
}

void AverageOfEveryColumns(int m, int n)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    int i, j;
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        double result = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        result = (sum / i);
        double roundResult = Math.Round(result,1);
        Console.Write($"| {roundResult} |");
    }
}
Matrix(m, n);
AverageOfEveryColumns(m,n);

