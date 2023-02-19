// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Вариант 1:
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
CheckTriangle(a, b, c);

void CheckTriangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b)) Console.Write("Условие верно!");
    else Console.Write("Условие не верно!");
}



// Вариант 2:
// Console.WriteLine("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) Console.Write("Существует");
// else Console.Write("Не существует");

// bool TriangleCheck(int n1, int n2, int n3)
// {
//     if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;
//     else return false;
// }
// if (TriangleCheck(n1, n2, n3)) Console.Write("Существует");
// else Console.Write("Не существует");