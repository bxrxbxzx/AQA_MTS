/*// See https://aka.ms/new-console-template for more information





/*
int[,] array = new int [4,5];
int[,] array =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};#1#

// -============================================= Трехмерный массив =============================================-

int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 }
    }
};

Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов


for (int i = 0; i <= array3D.GetUpperBound(0); i++)
{
    Console.WriteLine($"-========= Level {i} ==========-");
    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
    {
        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
        {
            Console.Write($"{array3D[i, j, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"-============================-");
    

    int[][] numbers =
    {
        new int[] { 1, 2 },
        new int[] { 1, 2, 3, 4, 5 },
        new int[] { 1, 2, 3 }
    };


    foreach (int[] row in numbers)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] = new Random().Next(100);
        }
    }

    for (int i = 0; i <= numbers.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
        {
            Console.Write($"{numbers[i][j]} \t");
        }

        Console.WriteLine();
    }
    

    int[][] numbers =
    {
        new int[] { 1, 2 },
        new int[] { 1, 2, 3, 4, 5 },
        new int[] { 1, 2, 3 }
    };


    foreach (int[] row in numbers)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] = new Random().Next(100);
        }
    }

    for (int i = 0; i <= numbers.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
        {
            Console.Write($"{numbers[i][j]} \t");
        }

        Console.WriteLine();
    }
}*/