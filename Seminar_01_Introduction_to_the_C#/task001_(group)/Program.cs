// Задача 001  (*в группе*): 
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго:
// Пример: а = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = -3, b = 9 -> нет


// Вариант 1 (в лоб):
Console.Write("Введите число 1: ");                         // запрос на ввод первого числа
int number1 = Convert.ToInt32(Console.ReadLine());          // прием первого числа

Console.Write("Введите число 2: ");                         // запрос на ввод второго числа
int number2 = Convert.ToInt32(Console.ReadLine());          // прием второго числа

int scuare = number2 * number2;                             // просчет квадрата числа 2
if (scuare == number1)                                      // проверка  равен ли полученный результата = num1
{
    Console.Write($"a = {number1}, b = {number2} -> да");   // если равен, то выводим на печать "да"
}
else
{
    Console.Write($"a = {number1}, b = {number2} -> нет");  // иначе выводим на печать "нет"
}


// Вариант 2 (через библу Math):
Console.Write("Input number 1: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int pow = Convert.ToInt32(Math.Pow(num_b, 2));
if (pow == num_a)
{
    Console.Write($"a = {num_a}, b = {num_b} -> yes");   // если равен, то выводим на печать "да"
}
else
{
    Console.Write($"a = {num_a}, b = {num_b} -> no");   // если равен, то выводим на печать "да"
}

