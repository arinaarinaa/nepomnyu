//Напишите программу, которая на вход принимает два числа и выдаёт
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int x;
Console.WriteLine("Пиши первое число тут: ");
x = Convert.ToInt32(Console.ReadLine());
int y;
Console.WriteLine("А тут второе пиши: ");
y = Convert.ToInt32(Console.ReadLine());
if (x<y)
{
    Console.WriteLine("Первое число меньше");
}
else
{
    Console.WriteLine("Второе число меньше");
}