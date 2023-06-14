// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


System.Console.WriteLine("Введите число (N): ");

int N = Convert.ToInt32(Console.ReadLine());

int EvenNum = 2;

System.Console.Write($"Четные числа от 1 до {N}: ");

while (EvenNum <= N)
{
    System.Console.Write($"{EvenNum}, ");
    EvenNum += 2;
}