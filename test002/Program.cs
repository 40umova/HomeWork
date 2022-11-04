//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int number01 = int.Parse(Console.ReadLine());
int number02 = int.Parse(Console.ReadLine());
int number03 = int.Parse(Console.ReadLine());
int max = number01;

if (number01 > max)
{
    max = number01;
}
 if (number02 > max)
 {
    max = number02;
 }
 if (number03 > max)
 {
    max = number03;
 }
 Console.WriteLine(max);
