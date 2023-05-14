// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные, и замените эти элементы на их квадраты.
// Например, изначально массив      Новый массив будет 
//  выглядел вот так:               выглядеть nfr
// 1 4 7 2                          1 4 7 2
// 5 9 2 3                          5 81 2 9
// 8 4 2 4                          8 4 2 4


int[,] arr = new int[3, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }

}

PrintArr(arr);

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],4}");  // ", 4" - выравнивание таблицы
        }
        Console.WriteLine();
    }
}


void NewArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                arr[i, j] *= arr[i, j];
            }
        }
    }
}

Console.WriteLine();
NewArray(arr);
PrintArr(arr);
