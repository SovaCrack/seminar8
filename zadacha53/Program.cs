// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      arr[i, j] = new Random().Next(-9,10); 
    }
    
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i, j]}\t"); 
       } 
       Console.WriteLine();    
    }
}
PrintArray(arr);
 
int[,] Change (int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) -1, i] = temp;
    }
    return array;

}
int[,] array = Change(arr);

Console.WriteLine();
PrintArray(array);