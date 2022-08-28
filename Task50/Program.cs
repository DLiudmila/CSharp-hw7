// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int[,] matrix = new int[4, 4];
FillArrayRandom(matrix);
PrintArray(matrix);

Console.WriteLine("Введите индекс элемента по строке: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента по столбцу: ");
int b = Convert.ToInt32(Console.ReadLine());
int? g = FindArrayCount(matrix, a, b);
if (g != null)
{
    Console.WriteLine(g);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет.");
}

void FillArrayRandom(int[,] mar)
{
    Random rand = new Random();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            mar[i, j] = rand.Next(0, 11);
        }
    }  
} 

int? FindArrayCount(int[,] mar, int a, int b)
{
    if(mar.GetLength(0) >= a && mar.GetLength(1) >= b)
    {
        return mar[a, b];
    }
    return null;
}

void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           Console.Write(mat[i, j] + " "); 
        }
        Console.WriteLine();
    }
}