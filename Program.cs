// // 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя)

// Console.Clear();

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// //int sqrt = number * number;
// // number *= number;
// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.Write("Число в квадрате: " + sqrt1);

// 2. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго числа.

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
    Console.Write("Первое число является квадратом второго числа");
else
    Console.Write("Первое число не является квадратом второго числа");
