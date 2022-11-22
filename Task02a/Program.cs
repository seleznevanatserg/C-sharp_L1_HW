//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter your first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Result: ");

if (num1 == num2)
{
    Console.Write(num1);
    Console.Write(" = ");
    Console.WriteLine(num2);
}
else
{
    if (num1 > num2)
    {
        Console.Write("max number: ");
        Console.WriteLine(num1);
    }

    else //(num1 < num2)
    {
        Console.Write("max number: ");
        Console.WriteLine(num2);
    }
}