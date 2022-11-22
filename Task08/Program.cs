//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter your number N: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

if (num <= 2 & num >= -2)
{
    Console.WriteLine("Value range too small");
}
else
{
    Console.WriteLine("It`s all even numbers bitween 1 to N");
    if (num > 0)
    {
        while (count < num)
        {
            if (count % 2 == 0)
            {
                Console.Write(count);
                Console.Write(" ");
            }
            count++;
        }
    }

    else
    {
        while (count > num)
        {
            if (count % 2 == 0)
            {
                Console.Write(count);
                Console.Write(" ");
            }
            count--;
        }
    }
}
Console.WriteLine();