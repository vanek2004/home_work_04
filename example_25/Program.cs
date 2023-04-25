// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("- Введите числа А и В -");
Console.Write("Число А --> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Число В --> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(numberA, numberB);
Console.WriteLine($"A в натуральной степени B = {degreeNumber}");

int DegreeNumber(int numA, int numB)
{
    int num = 1;
    for (int i = 1; i <= numB; i++)
    {
      num *= numA; 
    }
    return num;
}
