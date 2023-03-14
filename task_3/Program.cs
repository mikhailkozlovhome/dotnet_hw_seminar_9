// Задача 3:
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29


int InputInt(string msg)
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


int GetAkkermanFunc(int firstArgument, int secondArgument)
{
    if (firstArgument == 0)
    {
        return ++secondArgument;
    }
    if (firstArgument > 0 && secondArgument == 0)
    {
        return GetAkkermanFunc(firstArgument - 1, 1);
    }
    if (firstArgument > 0 && secondArgument > 0)
    {
        return GetAkkermanFunc(firstArgument - 1, GetAkkermanFunc(firstArgument, secondArgument - 1));
    }
    return -1;
}

int m = InputInt("Введите первый аргумент функции");
int n = InputInt("Введите второй аргумент функции");
int AkkermanFunc = GetAkkermanFunc(m, n);

if (AkkermanFunc == -1)
{
    System.Console.WriteLine($"Для аргументов {m} и {n} функция Аккермана не существует");
}
else
{
    System.Console.WriteLine($"Значение функции Аккермана с аргументами {m} и {n} равно {GetAkkermanFunc(m, n)}");
}
