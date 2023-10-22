// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      arr[i, j] = new Random().Next(0,10); 
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

void Count(int[,] array)
{
    int Count = 0;
    int number = 0;
    while(number < 10)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
           for (int j = 0; j < array.GetLength(1); j++)
           {
             if(array[i, j] == number) Count++;
           }    
        }
        if(Count > 0) Console.WriteLine($"Число {number} встречается {Count} раз");
        Count = 0;
        number++;
    }

}
Count(arr);

