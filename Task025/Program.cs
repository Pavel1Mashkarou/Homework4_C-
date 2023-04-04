int Start(string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    int a = int.Parse(Console.ReadLine());
    return a; 
}

int a = Start("число, которое будем вводить в степень");
int n = Start("степень числа:");

void Magic(int a, int n)
{
    int result = a;
    for (int i = 2; i<=n; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine($"Число {a} в степени {n} будет равно: {result}");
}

Magic(a,n);