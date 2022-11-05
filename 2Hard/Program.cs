// задача 2 HARD необязательная.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс.
// Вывести эту информацию на экран.
try
{
Console.Write("Укажите, сколько строк будет в массиве (введите натуральное число): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

// Создаем и заполняем массив
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,101);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);

int min = matrix[0,0];
int max = matrix[0,0];
int imax = 0;
int jmax = 0;
int amin = 0;
int bmin = 0;
//Ищем максимальное число
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
            imax = i;
            jmax = j;
        }
    }

}
//Ищем минимальное число
for (int a = 0; a < matrix.GetLength(0); a++)
{
    for (int b = 0; b < matrix.GetLength(1); b++)
    {
        if (matrix[a, b] < min)
        {
            min = matrix[a, b];
            amin = a;
            bmin = b;
        }
    }

}

Console.WriteLine($"Максимальный элемент массива: {max}, его индекс: ({imax}, {jmax}).");
Console.WriteLine($"Минимальный элемент массива: {min}, его индекс: ({amin}, {bmin}).");

}

catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}