Console.Write("Введите число обозначающее день недели, что бы выяснить, является ли номер дня недели выходным: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число обозначающее день недели: " + number);
if (number > 0 && number <= 7)
{
    if (number < 6)
    {
        Console.WriteLine("Номер дня недели НЕ является выходным");
    }
    else if (number >= 6)
    {
        Console.WriteLine("Номер дня недели Является выходным");
    }
}
else
    Console.WriteLine("В неделе семь дней! Введите число от 1 до 7");