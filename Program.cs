/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Например:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int FirstNumber = 0;
int SecondNumber = 0;

Console.Write("Введите первое число:  ");
FirstNumber = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse

Console.Write("Введите второе число:  ");
SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------");

if (FirstNumber > SecondNumber)
{
    Console.WriteLine ("Из чисел " + FirstNumber + " и " + SecondNumber + " наибольшее " + FirstNumber);
    Console.WriteLine ("Из чисел " + FirstNumber + " и " + SecondNumber + " наименьшее " + SecondNumber);
}
else
{
    Console.WriteLine ("Из чисел " + FirstNumber + " и " + SecondNumber + " наибольшее " + SecondNumber);
    Console.WriteLine ("Из чисел " + FirstNumber + " и " + SecondNumber + " наименьшее " + FirstNumber);

}
