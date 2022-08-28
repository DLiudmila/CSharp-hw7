// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] marray = new double[m, n];
FillArrayRandom(marray);
Console.WriteLine("Массив вещественных чисел.");
PrintArray(marray);

void FillArrayRandom(double[,] mar)
{
    Random rand = new Random();
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            mar[i, j] = rand.NextDouble();
        }
    }  
} 

void PrintArray(double[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           Console.Write(mat[i, j].ToString("0.0") + " "); 
        }
        Console.WriteLine();
    }
}
