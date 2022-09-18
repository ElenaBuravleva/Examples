Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Введено одно и то же число");
}
else
{    int Max;
if (number1 > number2)
{
    Max = number1;
}
else
{
    Max = number2;
}
Console.WriteLine("max = " + Max);
}