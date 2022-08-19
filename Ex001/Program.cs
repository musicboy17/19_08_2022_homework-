// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16



Console.WriteLine("Введите число А: ");
int Number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int Number_B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 1;
for (i = 1; i <= Number_B; i++)
{
    result = result * Number_A;
 
}

Console.WriteLine($"Число А в степени В равно - {result}");

