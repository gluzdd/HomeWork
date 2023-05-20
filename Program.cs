/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); // Первое число

Console.Write("ВВедите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());; // Второе число

if (firstNumber > secondNumber)
{
    // Да
    Console.WriteLine("Первое число " + firstNumber + "больше чем второе " + secondNumber);
}
else 
{
    // Нет
    Console.WriteLine("Второе число " + secondNumber + "больше чем первое " + firstNumber);
}

 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); // Первое число

Console.Write("ВВедите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); // Второе число

Console.Write("ВВедите второе число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine()); // Третье число

if(firstNumber > secondNumber)
{
    // Да
    if(firstNumber > thirdNumber)
    {    
        // Да
        Console.WriteLine("Максимальное число " + firstNumber);
    }
    else
    {    
        // Нет
        Console.WriteLine("Максимальное число " + thirdNumber);
    }
}
else
{
    // Нет
    if(secondNumber > thirdNumber)
    {
        // Да
        Console.WriteLine("Максимальное число " + secondNumber);
    }
    else
    {
        // Нет
        Console.WriteLine("Максимальное число " + thirdNumber);
    }
}


Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет


Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

if (NumberA%2 == 0)
{
    Console.WriteLine("Четное число, которое делится на два без остатка = " + NumberA);
}
else
{
    Console.WriteLine("Число, не является чётным " + NumberA);
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= N)
{
    Console.Write(i + ", ");
    i = i + 2;
}
*/