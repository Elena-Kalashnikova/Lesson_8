// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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
            Console.Write($"{matrix[i, j],+5}");

        }
        Console.WriteLine("| ");
    }

}
 

int[] FindPosOfMin(int[,] matrix)
{
    
    int min_row = 0;
    int min_col = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= matrix[min_row, min_col])
            {
                min_row = i;
                min_col = j;
            }

        }

    }
    return new int[] { min_row, min_col };
}

int[,] RemoveCrosseMinElem(int[,] matrix, int row, int col)
{

    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (n == col) n++;
            result[i, j] = matrix[m, n];
            n++;

        }
        n = 0;
        m++;
    }
    return result;
}

int[,] array_2d = CreateMartixRndInt(3, 4, 1, 9);
PrintMatrix(array_2d);
Console.WriteLine(" ");
int[] pos = FindPosOfMin(array_2d);
int[,] res = RemoveCrosseMinElem(array_2d, pos[0], pos[1]);
PrintMatrix(res);