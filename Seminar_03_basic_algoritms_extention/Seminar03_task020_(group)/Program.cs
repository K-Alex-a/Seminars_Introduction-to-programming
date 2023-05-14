// Задача 020  (*в группе*):
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// Пример: A (3,6); B (2,1) -> 5,09;  A (7,-5); B (1,-1) -> 7,21

// x1-x2=n (в квадрате)
// y1-y2=m (в квадрате)
// n+m <- из этого корень

// Console.Write("Введите x1: ");              // запрос ввода числа х1
// int x1 = int.Parse(Console.ReadLine());     // прием введенного числа под переменную х1
// Console.Write("Введите y1: ");              // запрос ввода числа y1
// int y1 = int.Parse(Console.ReadLine());     // прием введенного числа под переменную y1
// Console.Write("Введите x2: ");              // запрос ввода числа х2
// int x2 = int.Parse(Console.ReadLine());     // прием введенного числа под переменную х2
// Console.Write("Введите y2: ");              // запрос ввода числа y2
// int y2 = int.Parse(Console.ReadLine());     // прием введенного числа под переменную y2

// int num1 = x1 - x2;                         // ввод новой переменной num1 с расчетом
// int num2 = y1 - y2;                         // ввод новой переменной num2 с расчетом   

// double sum = Math.Round((Math.Pow(num1, 2) + Math.Pow(num2, 2)), 3);        // раунд не работает, почему?
// Console.WriteLine(Math.Sqrt(sum));



// Вариант 2:
Console.WriteLine("Введите координаты точки 1: ");       // запрос ввода координат точки 1
string[]? sArr = Console.ReadLine()?.Split(' ');           // вывод на печать строкой через пробел
int num1 = Convert.ToInt32(sArr?[0]);                     // прием первого числа под переменную num1
int num2 = Convert.ToInt32(sArr?[1]);                     // прием второго числа под переменную num2

Console.WriteLine("Введите координаты точки 2: ");       // запрос ввода координат точки 2
string[]? sArr2 = Console.ReadLine()?.Split(' ');          // вывод на печать строкой через пробел
int num3 = Convert.ToInt32(sArr2?[0]);                    // прием первого числа под переменную num3
int num4 = Convert.ToInt32(sArr2?[1]);                    // прием первого числа под переменную num4

double result = Math.Round(Math.Sqrt(Math.Pow((num3 - num1), 2)+ Math.Pow((num4 - num2),2)), 3);         // расчет по формуле
Console.Write(result);                                   // вывод на печать результата




// Вариант 3:
// Random rand = new Random();                                                  // присвоение переменной рандом к новому рандому

// int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101);                    // выбор координат точки 1 рандомом
// int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101);                    // выбор координат точки 2 рандомом

// Console.WriteLine($"Point A  ({x1}, {y1})");                                 // вывод на печать полученнях координат первой точки
// Console.WriteLine($"Point B  ({x2}, {y2})");                                 // вывод на печать полученнях координат второй точки

// double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));      // расчет формулой
// Console.WriteLine(Math.Round(length,2));                                     // вывод итога с округлением до 2 цифр после запятой