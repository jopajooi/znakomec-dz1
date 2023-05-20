// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Enter number A   ");
System.Console.WriteLine("Enter number B   ");
System.Console.WriteLine("Enter number C   ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int big = A;
if (B > big) big = B;

if (C > big) big = C;
System.Console.WriteLine($"It's   --{big}--");

