// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число А: ");
int Number_A = Convert.ToInt32(Console.ReadLine());
string sen = Convert.ToString(Number_A);
int i = 0;
int j = 0;
int rez = 1;
int l01 = 10;
int Zumm = 0;


for (i = 1; i <= sen.Length; i++)

{
    int result =  Number_A % 10;
    Console.WriteLine($"число {i}: {result}");
    
    for (j=1; j <= sen.Length; j++)
    rez = Number_A / l01 * 10 ;
    Number_A = Number_A / 10;

    int result02 =  rez % 10;
    l01=l01*10;
    Zumm = Zumm + result;
}

// Console.WriteLine($"число А: {Number_A}");

// int result01 =  Number_A % 10;

// Console.WriteLine($"число 1: {result01}");

// int result02 =  (Number_A /10) % 10;

// Console.WriteLine($"число 2: {result02}");

// int result03 =  (Number_A /100) % 10;

// Console.WriteLine($"число 3: {result03}");

Console.WriteLine($"порядок числа А: {sen.Length}");
Console.WriteLine($"Сумма цифр в числе А: {Zumm}");
