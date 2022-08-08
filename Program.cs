// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя)

Console.Clear();

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
//int sqrt = number * number;
// number *= number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.Write("Число в квадрате: " + sqrt1);