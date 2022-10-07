// Программа получает два числа и определяет кратность первого второму или выводит 
// остаток от деления
//Console.WriteLine($"Введите первое целое число: ");
//int.TryParse(Console.ReadLine(), out int number1);
//Console.WriteLine($"Введите второе целое число: ");
//int.TryParse(Console.ReadLine(), out int number2);
int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}
int number1 = EnterNumber();
int number2 = EnterNumber();
if (number1 % number2 == 0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else Console.WriteLine($"Остаток от деления {number1} / {number2} равен {number1 % number2}");