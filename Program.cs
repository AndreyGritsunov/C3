Console.WriteLine("Введите число");
int number_one = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number_two = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number_three = Convert.ToInt32(Console.ReadLine());

int Max = 0;

if (number_one > number_two) Max = number_one;
if (number_two > Max) Max = number_two;
if (number_three > Max) Max = number_three;

Console.Write(Max);