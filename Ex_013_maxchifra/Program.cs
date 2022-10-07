//Программа выводит случайное число из диапазона [ 10, 99] 
// и находит максимальную цифру в числе
Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (a2 > max) max = a2;
Console.WriteLine($"в числе {num} максимальная цифра {max}");