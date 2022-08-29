// Напишите цикл, который принимает на вход два числа А и В
//  и возводит число А в натуральную степень
// 3,5 -> 243
// 2,4 -> 16

Console. Write("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console. Write("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int counter = 2;
int num1 = numberA*numberA;

while (counter < numberB)
{
    num1 = num1 * numberA;
    counter = counter + 1;
}

Console. Write($"Степень числа {numberA} в числе {numberB} = {num1}");

// int DegreeAB(int number1, int number2)
// {
//     int counter = 2;
//     int proizvedenie = number1 * number2;
//     while (counter < number2)
//         {
//             proizvedenie = proizvedenie * number1;
//             counter = counter + 1;
//         }
//     return proizvedenie;
// }
// int result = DegreeAB(numberA, numberB);
// Console. Write($"Степень числа {numberA} в числе {numberB} = {result}");



