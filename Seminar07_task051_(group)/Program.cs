// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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


int Sum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                result += arr[i, j];
            }
        }
    }
    return result;
}

Console.WriteLine($"Сумма элементов главной диагонали: {Sum(arr)}");

// Вариант 2 ( с красивым выводом):
// int[,] array = new int[5, 5];
// array = FillArray(array);


// int[,] FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 11);
//         }
//     }
//     return arr;
// }



// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j],4}");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array);

// void DiogonalSumm(int [,] arr)
// {
//     int sum = 0;
//     Console.WriteLine("Summ of diogonal number: ");
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//            if(i==j)
//            {
//             Console.Write($"{arr[i,j]} + ");
//             sum +=  arr[i,j];
//            }
//         }
//      }
//      Console.Write("\b\b= ");
//      Console.Write($"{sum}");
// }
   
// DiogonalSumm(array);