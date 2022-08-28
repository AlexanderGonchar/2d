Console.Write("Введите первое целое число - ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число - ");
int numberB = int.Parse(Console.ReadLine());

int numberC = numberA * numberA;
int numberD = numberB * numberB;

if (numberB == numberC)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else if (numberD == numberA)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого");
}