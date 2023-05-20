// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Enter number:   ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(n % 2);
int number = n % 2;

if (number == 0)
    System.Console.WriteLine($"Число {number} чётное");

if (number > 0)

    System.Console.WriteLine($"Число {number} не чётное");

if (number < 0)
    System.Console.WriteLine($"Число {number} не чётное");
