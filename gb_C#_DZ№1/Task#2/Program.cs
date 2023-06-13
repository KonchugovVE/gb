// See https://aka.ms/new-console-template for more information
int i = 0;
Console.Write("Введите колличество эемепнтов массива: ");

int elCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elCount];

for (i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите значение массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("ввывод массива:");

for (i = 0; i < myArray.Length; i++)
{ Console.Write(myArray[i]); }
