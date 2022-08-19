// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array_new = new int[8];

for (int i = 0; i < array_new.Length; i++)
{
    array_new[i] = new Random().Next(99);        
}

void printarray(int[] array)
{
    int Count = array.Length;
    for (int i = 0; i < Count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();

}
printarray(array_new);