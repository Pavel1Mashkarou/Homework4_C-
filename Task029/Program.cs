int[] array = new int[8];

void Magic(int[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.WriteLine("Введите число:");
        array[a] = int.Parse(Console.ReadLine());
    }
    Console.Write("[");
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write(array[a]);
        if (a < array.Length - 1)
        {
            Console.Write(";");
        }
    }
    Console.WriteLine("]");
}

Magic(array);
