Console.Write("Задайте номер четверти - ");
int qarter = int.Parse(Console.ReadLine());
if (qarter == 1) Console.WriteLine("х должен быть положительным, у - тоже положительный");
if (qarter == 2) Console.WriteLine("х должен быть отрицательным, у - положительный");
if (qarter == 3) Console.WriteLine("х должен быть отрицательным, у - тоже отрицательным");
if (qarter == 4) Console.WriteLine("х должен быть положительным, у - отрицательным");
if (qarter == 0 | qarter > 4) Console.WriteLine("четвертей всего 4, очевидно же! Попробуйте заново");