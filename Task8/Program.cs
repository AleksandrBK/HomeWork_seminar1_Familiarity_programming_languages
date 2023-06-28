//  Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");

int digitN = Convert.ToInt32(Console.ReadLine()); 

int evenDigit = 2;

Console.WriteLine("Все четные числа от 1 до числа " + digitN + ": ");
while (evenDigit < digitN-2) 
{
    Console.Write(evenDigit + "; ");
    evenDigit +=  2; 
}
Console.Write(evenDigit);