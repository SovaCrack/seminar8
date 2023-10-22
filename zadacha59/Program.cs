// Задайте двумерный массив из целых чисел.Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите размер масива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер масива n: ");
int n =  Convert.ToInt32(Console.ReadLine());

int[,] arry = new int[m, n];
for (int i = 0; i < arry.GetLength(0); i++)
{
    for (int j = 0; j < arry.GetLength(1); j++)
    {
       arry[i, j] = new Random().Next(-9, 10);
    }  
}

void PrintArry(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
       for (int j = 0; j < arry.GetLength(1); j++)
       {
        Console.Write($"{arry[i, j]}\t");
       } 
    }
    Console.WriteLine();
}
PrintArry(arry);

Console.WriteLine();

int[] findMinNumberLoc(int[,] arry)
{
    int min = arry[0, 0];
    int[] result = new int[] {0,0};
    for (int i = 0; i < arry.GetLength(0); i++)
    {
       for (int j = 0; j < arry.GetLength(1); j++)
       {
        if(arry[i, j] < min)
        {
            min = arry[i, j];
            result[0] = i;
            result[1] = j;
        }
       } 
    }
   return result;
}

int[] ignore = findMinNumberLoc(arry);

Console.WriteLine($"{ignore[0]}, {ignore[1]}");

void PrintFinalArry(int[,] arry, int[] ignore)
{ 
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if(i != ignore[0] && j != ignore[1])
            {
                Console.Write($"{arry[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}

PrintFinalArry(arry, ignore);

int[,] FinalArry = new int[m -1, n -1];

for (int i = 0; i < ignore[0]; i++)
{
    for (int j = 0; j < ignore[1]; j++)
    {
        FinalArry[i, j] = arry[i, j];
    }
}

for (int i = ignore[0]; i < FinalArry.GetLength(0); i++)
{
    for (int j = ignore[1]; j < FinalArry.GetLength(1); j++)
    {
        FinalArry[i, j] = arry[i+1, j+1];
    }
}

for (int i = ignore[0]; i < FinalArry.GetLength(0); i++)
{
    for (int j = 0; j < ignore[1]; j++)
    {
        FinalArry[i, j] = arry[i+1, j];
    }
}

for (int i = 0; i < ignore[0]; i++)
{
    for (int j = ignore[1]; j < FinalArry.GetLength(1); j++)
    {
        FinalArry[i, j] = arry[i, j+1];
    }
}

Console.WriteLine();


PrintArry(FinalArry);