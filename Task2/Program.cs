/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Enter coordinate x1:");
int y1 = ReadInt("Enter coordinate y1:");
int z1 = ReadInt("Enter coordinate z1:");
int x2 = ReadInt("Enter coordinate x2:");
int y2 = ReadInt("Enter coordinate x2:");
int z2 = ReadInt("Enter coordinate x2:");

int x = x2 - x1;
int y = y2 - y1;
int z = z1 - z2;

double length = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"Length of the segment {length}:");
