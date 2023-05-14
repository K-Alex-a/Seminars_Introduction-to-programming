// Задача 018 (*в группе*):
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y):



// Вариант 1:
Console.Write("Введите х: ");                               // запрос ввода числа
int num = Convert.ToInt32(Console.ReadLine());                    // прием числа под переменную num

if (num == 1) Console.WriteLine("x > 0 && y > 0");          // проверка условием, если num равна 1, то выводим на печать...
else if (num == 2) Console.WriteLine("x < 0 && y > 0");     // проверка условием, если num равна 2, то выводим на печать...
else if (num == 3) Console.WriteLine("x < 0 && y < 0");     // проверка условием, если num равна 3, то выводим на печать...
else if (num == 4) Console.WriteLine("x > 0 && y < 0");     // проверка условием, если num равна 4, то выводим на печать...
else Console.WriteLine("Error");                            // иначе выводим на печать...



// Вариант 2 (через кейсы):
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("x > 0 && y > 0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x < 0 && y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x < 0 && y < 0");
//         break;
//     }
//      case 4:
//     {
//         Console.WriteLine("x > 0 && y < 0");
//         break;
//     }
//     default: 
//     {
//         Console.WriteLine("Нет данных");
//         break;
//     }
// }
