// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
try{
Console.Write("Укажите, сколько чисел будет в массиве (введите натуральное число): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write($"Введите число {index + 1} для заполнения массива из {size} элементов: ");
        arr[index] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);

int num = 0;
 for (int i = 0; i < size; i++)
 {
    if (array[i] > 0) 
    {
        num++;
    }
 }

Console.WriteLine($"Количество чисел больше 0 в данном массиве: {num}.");
}

catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}