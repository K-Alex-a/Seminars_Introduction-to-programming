// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.



int[,] arr = new int[4, 4];
int[,] tempArr = new int[4, 4];

if (arr.GetLength(0) == arr.GetLength(1))
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    PrintArr(arr);
    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[i, j] = arr[j, i];
        }

    }
    arr = tempArr;
    PrintArr(arr);
}
else Console.WriteLine("Операция не возможна!");



void PrintArr(int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    }
}


// Вариант 2 (достать полный с семинара):
// Console.Clear();
// int row = new Random().Next(5,7);

// int[,] array = new int[row, row];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// if (array.GetLength(0) != array.GetLength(1) ) 
// {
//     Console.WriteLine("Не возможное условие выполнения программы");
//     return;
// } 
// void ModifyArray(int [,] arr)
// { 
//     for (int row = 0; row < arr.GetLength(0); row++)
//     {
//       for (int col = row+1; col < arr.GetLength(1); col++)
//       {
//         int temp = arr[row,col];
//         arr[row,col] = arr[col,row];
//         arr[col,row] = temp;
//       }
//     }
// }