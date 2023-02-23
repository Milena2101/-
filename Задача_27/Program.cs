/*
Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();
Console.Write(" Number: ");
int i = Convert.ToInt32(Console.ReadLine());
int Sum_of_digits = 0;

while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    Sum_of_digits = Sum_of_digits + number;
}
Console.WriteLine("The sum is equal to = " + Sum_of_digits );
