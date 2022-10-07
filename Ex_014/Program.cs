//Программа выводит случайное число из диапазона [ 100, 999] 
// и убирает среднюю цифру в числе
Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;
int result = a1 * 10 + a3;
Console.WriteLine($"Из числа {num} -> {result}");
