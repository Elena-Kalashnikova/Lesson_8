// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}
int[] TransformationMatrixInArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //if (count<matrix.Length)
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}
void FrequencyArray(int[] array)
{
    int current_number = array[0];
    int count = 1;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == current_number)
        {
            count++;
        }
        else {Console.WriteLine($"{current_number} содержится {count} раз(а)");
            current_number = array[i];
        count = 1;}
    }
    Console.WriteLine($"{current_number} содержится {count} раз(a)");
}

        int[,] array_2d = CreateMartixRndInt(3, 4, 1, 9);
        PrintMatrix(array_2d);
        int[] arr = TransformationMatrixInArray(array_2d);
        Array.Sort(arr);
        PrintArray(arr);
        FrequencyArray(arr);