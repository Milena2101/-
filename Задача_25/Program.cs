/*
Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
*/
Console.Clear();
Console.Write("Number А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int pover = A;

for ( int i =1; i < B; i++)
{
    pover = pover * A;
}
Console.WriteLine("А в тепени В = " + pover);