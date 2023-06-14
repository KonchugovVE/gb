// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.Write("Введите число: ");
int addnum = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"\nЧисло является ");
if (addnum % 2 == 0)
{
    System.Console.WriteLine("четным");
}
else
{
    System.Console.WriteLine("не четным");
}