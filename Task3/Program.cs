/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Например: 3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125*/

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Enter number N:");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i * i);
}
