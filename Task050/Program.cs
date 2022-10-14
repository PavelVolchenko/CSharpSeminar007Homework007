/*  Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
    5 -> 9
    2 -> 7
    9 -> 4
    индексы:
    [0][1][2][3]
     1  4  7  2
    [4][5][6][7]
     5  9  2  3
    [8][9][10][11]
     8  4   2  4                                                                                         */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void findElementInArray(int[,] generateArray, int position)
{
    if (position < generateArray.GetLength(1))
    {
        Console.WriteLine($"{position} -> {generateArray[0, position]}");
    }
    else
    {   int row = (position / generateArray.GetLength(1));        
        int column = (position % generateArray.GetLength(1));
        Console.WriteLine($"{position} -> {generateArray[row, column]}");
    }
}

Console.WriteLine("Задайте двумерный массив.");
Console.Write("Количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());

int[,] generateArray = generate2DArray(height, width, 1, 9);
print2DArray(generateArray);
findElementInArray(generateArray, position);