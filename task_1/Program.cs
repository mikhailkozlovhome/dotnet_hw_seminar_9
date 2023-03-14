// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
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

void ShowEvenNumbers (int numberFrom, int numberTo)
{
    if (numberTo < numberFrom)
    {
        return;
    }

    
    
    if (numberTo %2 ==0)
    {
        ShowEvenNumbers(numberFrom, numberTo - 2);
        System.Console.Write($"{numberTo} ");
    }
    else
    {
        ShowEvenNumbers(numberFrom, numberTo - 1);
    }
}

int m = inputInt("Введите первое число");
int n = inputInt("Введите второе число");

ShowEvenNumbers(m, n);

