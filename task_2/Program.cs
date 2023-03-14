// Задача 2:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int inputInt(string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}


int GetNumbersSum (int numberFrom, int numberTo)
{
    if (numberTo < numberFrom)
    {
        return 0;
    }
    return numberTo + GetNumbersSum(numberFrom, numberTo - 1);
}

int m = inputInt("Введите первое число");
int n = inputInt("Введите второе число");

System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {GetNumbersSum(m, n)}");
