// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if(firstDigit > secondDigit)
{
    Console.WriteLine("Число " + firstDigit + " является наибольшим ");
    Console.WriteLine("Число " + secondDigit + " является наименьшим ");
}
else
{
    Console.WriteLine("Число " + secondDigit + " является наибольшим ");
    Console.WriteLine("Число " + firstDigit + " является наименьшим ");
}