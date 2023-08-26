// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMartixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],+5}");

        }
        Console.WriteLine("| ");
    }

}

void ChangeRowsColums(int[,] matrix)
{
// if(matrix.GetLength(0) != matrix.GetLength(1) )
// Console.WriteLine("невозможно поменять строки");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;

        }
    }
}

bool ChangeSquareMatrix(int[,] matrix){
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] array_2d = CreateMartixRndInt(4, 3, -100, 100);
if (!ChangeSquareMatrix(array_2d)) {
Console.WriteLine("Невозможно поменять строки и столбцы");
return;}
PrintMatrix(array_2d);
ChangeRowsColums(array_2d);

Console.WriteLine(" ");
PrintMatrix(array_2d);
