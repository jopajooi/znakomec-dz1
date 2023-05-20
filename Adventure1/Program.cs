
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Enter number A   ");
System.Console.WriteLine("Enter number B   ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int big = A;
if (B > A)
{
    big = B;
    System.Console.WriteLine($" {B} больше чем {A}");
}
else
    System.Console.WriteLine($" {A} больше чем {B}");

