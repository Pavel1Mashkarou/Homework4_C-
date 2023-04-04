int Start()
{
    System.Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());
    return a; 
}

int a = Start();

void Summ(int a)
{
    int result = 0;
    while (a!=0)
    {
        result = result + a % 10;
        a = a / 10;
    }
    System.Console.WriteLine(result);
}

Summ(a);