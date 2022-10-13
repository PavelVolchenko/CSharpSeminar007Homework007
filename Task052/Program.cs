/*  Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
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
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void printArray(double[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write("{0:#.#}", incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(".");
}

double[] avgArithmetic(int[,] generateArray)
{
    double[] avgArray = new double[generateArray.GetLength(1)];
    double sumColumn = 0;
    for (int i = 0; i < generateArray.GetLength(1); i++)
    {
        for (int j = 0; j < generateArray.GetLength(0); j++)
        {
            sumColumn += generateArray[j,i];
        }
        avgArray[i] = sumColumn / (double)generateArray.GetLength(0);
        sumColumn = 0;
    }
    return avgArray;
}

Console.WriteLine("Задайте двумерный массив.");
Console.Write("Количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] generateArray = generate2DArray(height, width, 1, 9);
print2DArray(generateArray);

double[] avgArithmeticArray = avgArithmetic(generateArray);
Console.Write("Среднее арифметическое каждого столбца: ");
printArray(avgArithmeticArray);