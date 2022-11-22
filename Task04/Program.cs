//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter your first number: ");
int num1 = int.Parse(Console.ReadLine ());

Console.WriteLine("Enter your second number: ");
int num2 = int.Parse(Console.ReadLine ());

Console.WriteLine("Enter your third number: ");
int num3 = int.Parse(Console.ReadLine ());

int max = num1;

if (max <= num2)
{
	max = num2;
}

if (max <= num3)
{
	max = num3;
}

Console.Write(max);
Console.WriteLine(" it`s max number");