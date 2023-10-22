// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 1; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(-9,10); 
    }
    
}
int[,] TranspArray(int[,] array)
{
    //int[,] result = new int[array.GetLength(1),array.GetLength(0)];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
        
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 1; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i, j]}\t"); 
       } 
       Console.WriteLine();    
    }
}
PrintArray(arr);
Console.WriteLine();

if(n==m)
{
    PrintArray(TranspArray(arr));
}
else
{
    System.Console.WriteLine("m != n");
}