/*
Напишите метод, который задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();

int array = ReadLine("Длина массива: ");
Console.Write("[");

int[] random = new int[array];
for (int i = 0; i < random.Length; i++)
{
    random[i] = new Random().Next(1, 9);
    Console.Write(random[i] + " ");
}
int ReadLine(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.Write("]");