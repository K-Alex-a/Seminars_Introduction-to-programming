// double num = (new Random().NextDouble())*10;      // вещественные числа(дробные)
// Console.WriteLine(Math.Round(num,2))              // округление до 2 знаков после запятой

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min значение массива: ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max значение массива: ");
int maxArr = Convert.ToInt32(Console.ReadLine());

int[] GetArr(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minArr, maxArr + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void ReversArry(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arry = GetArr(n);
PrintArr(arry);
ReversArry(arry);