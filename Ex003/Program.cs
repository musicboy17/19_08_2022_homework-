// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array_new = {10, 8, 1, 3, 5, 5, 7,7};
int i = 0;
void printarray(int[] array)
{
    int Count = array.Length;
    for (int i = 0; i < Count; i++);
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}
printarray(array_new);