Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int n = a;
a = 2;
while(a <= n)
{
    Console.WriteLine(a);
    a = a + 2;
}