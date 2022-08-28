// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] marray = new int[m, n];
FillArrayRandom(marray);
Console.WriteLine("Исходный массив");
PrintArray(marray);
PrintAverageColumn(marray);
Console.WriteLine();

void FillArrayRandom(int[,] mar)
{
    Random rand = new Random();
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
            mar[i, j] = rand.Next(0, 9);
        }
    }  
} 

void PrintArray(int[,] mar)
{
    for (int i = 0; i < mar.GetLength(0); i++)
    {
        for (int j = 0; j < mar.GetLength(1); j++)
        {
           Console.Write(mar[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

void PrintAverageColumn(int[,] mar)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < mar.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < mar.GetLength(0); i++)
        {
            sum = sum + mar[i,j];
        }
        double avg = 0;
        avg = (double)sum / mar.GetLength(0); 
        Console.Write(avg.ToString("0.0") + "; ");
    }
    
}