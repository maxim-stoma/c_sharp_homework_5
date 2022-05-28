void SetArray(int[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        variety[index] = new Random().Next(-99, 100); // [-99, 100)
    }
}

void PrintArray(int[] multitude)
{
    Console.Write("[ ");
    for (int pos = 0; pos < multitude.Length; pos++)
    {
        Console.Write(multitude[pos]);

        if (pos != multitude.Length - 1)
        {
            Console.Write(", ");
        }

        if (multitude[pos] == multitude[multitude.Length / 2 - 1])
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ResetColor();
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}

void BorderElementMultiplication(int[] pile)
{
    int mult;

    for (int position = 0; position < pile.Length / 2; position++)
    {
        int factor1 = pile[position];
        int factor2 = pile[pile.Length - position - 1];
        mult = factor1 * factor2;
        Console.WriteLine($"Произведение {position + 1} пары элементов равна {mult}. ");
    }
    if (pile.Length % 2 == 0)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"А {pile[pile.Length / 2]} - просто элемент, расположенный посередине. ");
    }
}

Console.Write("Введи размер массива: ");
int s = Convert.ToInt32(Console.ReadLine()); // переменная s задаёт размер массива
int[] array = new int[s];

SetArray(array);
PrintArray(array);
BorderElementMultiplication(array);

Console.ReadLine();