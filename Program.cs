Console.Clear();

Console.Write("Введите любое целое число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{digital_sum(num)}");

int digital_sum(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum  += x % 10;
        x = x / 10;
    }
    return(sum);
}