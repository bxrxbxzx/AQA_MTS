/*// See https://aka.ms/new-console-template for more information

int[] array = {1, 9, 3, 6, 5 };

int[] array1;
int n = 4;
array1 = new int[n];


int[] array2 = new int[5] {1, 9, 3, 6, 5 };

//Console.WriteLine(array[2]);
//Console.WriteLine(array[0]);

//array[0] = 10;
//Console.WriteLine(array[0]);

 Console.WriteLine($"Last item in array: {array[array.Length-2]}");
 Console.WriteLine($"Last item in array: {array[^2]}");
Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");


Console.WriteLine("Lenght: " +array.Length);      //кол-во всех элементов
Console.WriteLine("Rank: " +array.Rank);          //ранк массива
Console.WriteLine("GetLenght(0): " +array.GetLength(0));    //кол-во строк
Console.WriteLine("GetUpperBound(0): " +array.GetUpperBound(0));   //Верхний индекс строк
Console.WriteLine("GetLowerBound(0): " +array.GetLowerBound(0));   //Нижний индекс строк

//
// for(объявление переменной; условие; изменение переменной)
// {
//
// }


int[] array = { 1, 9, 3, 6, 5 };

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.GetUpperBound(0); i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
foreach (int item in array)
{
    Console.Write($"{item} ");
}

//в этом массиве переинициилизируем элементы (внесем другие значения в массив)
Console.WriteLine();
for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    array[i] = new Random().Next(100);
}

foreach (int item in array)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

//можно вывести 10 раз слово Hello
for (int i = 1; i <= 10; i++)
{
 Console.WriteLine($"{i} Hello!");
}


for (int i = 0; i <= 10; i += 2)
{
 Console.Write($"{i} ");
}

Console.WriteLine();
string text = "Hello!!!";
foreach (char ch in text)
{
 Console.Write($"{ch} ");
}
int n = 10;
for (int i = n; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);

    Console.WriteLine();
}

for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}

int[] arr1 = new int[6];

int u = 6;
bool flag = true;

do
{
    if (u < 0) flag = false;
    
    Console.WriteLine($"{u}");
    u--;
} while (flag);

u = 6;
do
{
    Console.WriteLine($"{u}");
    u--;
}while (u>=0);*/


// -----Двумерный массив-----

using System.Data;

int[,] array = new int[4, 5];
Console.WriteLine("Lenght: " +array.Length);      //кол-во всех элементов
Console.WriteLine("Rank: " +array.Rank);          //ранк массива
Console.WriteLine("GetLenght(0): " +array.GetLength(0));    //кол-во строк
Console.WriteLine("GetUpperBound(0): " +array.GetUpperBound(0));   //Верхний индекс строк
Console.WriteLine("GetLenght(1): " +array.GetLength(1));    //кол-во столбцов
Console.WriteLine("GetUpperBound(1): " +array.GetUpperBound(1));   //Верхний индекс столбцов
Console.WriteLine("GetLowerBound(0): " +array.GetLowerBound(0));   //Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " +array.GetLowerBound(1));   //Нижний индекс столбцов
Console.WriteLine("=========");

/*int[,] nums1 = new int[2, 3];
int[,] nums2 = new int[2, 3] {{0,1,2},{3,4,5}} ;*/

//Задание значений.
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }
}
//2 вариант вывода
int rows = array.GetLength(0);
int columns = array.Length / rows;
for(int i = 0; i<rows; i++)
{
    for (int j = 0; (j) < columns; (j)++)
    {
        Console.Write($"{array[i,j]} \t");
    }
    Console.WriteLine();
}
//3 вариант вывода
foreach (int item in array)
{
    Console.Write($"{item} ");
    ;
}
