Console.WriteLine("Ввежите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввежите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввежите тетье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;
Console.WriteLine($"Максимальное число {max}");