Console.WriteLine("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
    {
        Console.Write("Большее число ");
        Console.WriteLine(b);
    }
else 
    {
        Console.Write("Большее число ");
        Console.WriteLine(a);
    }