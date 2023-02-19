// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int n)
{
    if (n == 0) return 0;
    return n % 10 + PrintNumbers(n / 10);
}

Console.WriteLine(PrintNumbers(num));

