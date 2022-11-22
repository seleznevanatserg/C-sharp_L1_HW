//**Задача 6:** Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter your number: ");
int num = int.Parse(Console.ReadLine ());
int remainder = num % 2;
if (remainder == 0)
{
	Console.WriteLine("Yes, it`s even number");
}
else
{
	Console.WriteLine("NO. it`s uneven number");
}
