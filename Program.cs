Console.Write("Введите первое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье значение: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"Максимальное значение = {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Максимальное значение = {b}");
}
else if (c > a && c > b)
{
    Console.WriteLine($"Максимальное значение = {c}");
}
else if (a == b && b == c)
{
    Console.WriteLine($"Введенв равнозначные значения");
}