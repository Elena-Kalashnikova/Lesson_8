// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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
            Console.Write($"{matrix[i, j], +    5}");

        }
        Console.WriteLine("| ");
    }
    
}
void LineChange(int[,] matrix)
{
   int first_Row = 0;
   int last_Row = matrix.GetLength(0)-1;
        for (int j = 0; j < matrix.GetLength(1); j++){

    int temp = matrix[first_Row, j];
    matrix[first_Row, j] = matrix[last_Row, j];
    matrix[last_Row,j] = temp;

        }
       
}



int[,] array_2d = CreateMartixRndInt(3, 4, -100, 100);
PrintMatrix(array_2d);
LineChange(array_2d);
Console.WriteLine(" ");
PrintMatrix(array_2d);
