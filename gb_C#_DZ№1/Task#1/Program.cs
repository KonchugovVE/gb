//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;
Console.Write("Введите значение 'А'-> ");

string input_numberA = Console.ReadLine();
int numberA = Convert.ToInt32(input_numberA);

Console.Write("Введите значение 'B'-> ");
string input_numberB = Console.ReadLine();
int numberB = Convert.ToInt32(input_numberB);

if (numberA > numberB)
{ max = numberA; min = numberB; }
else
{ max = numberB; min = numberA; }

Console.WriteLine($"{max} больше {min}");
Console.WriteLine($"Max = {max}, Min = {min}");


