// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Вариант 1:
// Console.Clear();
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int first = 0;
// int second = 1;
// int temp = 0;
// Fib(num);
// void Fib(int num)
// {
//     int result = 0;
//     for (int i = 0; i <= num; i++)
//     {
//         Console.Write(first + " ");
//         temp = second;
//         second = second + first;
//         first = temp;
//     }
// }



// Вариант 2 (через массив):
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Если N = {num} -> ");

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}
Console.Write(string.Join(" ", Fibonacci(num)));


// Вариант 4 (рекурсия):
// static long Fib(int n)
// {
//     if ((n == 0) || (n == 1))
//         return n;
//     return Fib(n - 1) + Fib(n - 2);