// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

// Вариант 1 (не по условию):
// int[,] arr = new int[3, 4];
// int[] tempArr = new int[4];


// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(1, 10);
//     }
// }
// PrintArr(arr);
// Console.WriteLine();

// for (int i = 0; i < 4; i++)
// {
//     tempArr[i] = arr[0, i];
//     arr[0, i] = arr[2, i];
//     arr[2, i] = tempArr[i];
// }

// PrintArr(arr);

// void PrintArr(int[,] arry)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }


// Вариант 2:
