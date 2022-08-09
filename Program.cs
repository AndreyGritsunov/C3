Console.WriteLine("Введите число");
int number_one = Convert.ToInt32(Console.ReadLine());
int result = number_one % 2;

if (result == 0) 
{
    Console.Write("Четное");
}
else
{
    Console.Write("Не четное");    
}