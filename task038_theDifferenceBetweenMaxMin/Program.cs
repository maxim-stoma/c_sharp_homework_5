void SetArray(double[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        variety[index] = new Random().NextDouble() * 200 - 100;
    }
}

void PrintArray(double[] multitude)
{
    Console.Write("[ ");
    for (int pos = 0; pos < multitude.Length; pos++)
    {
        Console.Write(Math.Round(multitude[pos], 2));
        if (pos != multitude.Length - 1)
        {
            Console.Write(" | ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}

void MaxMinDifference(double[] pile)
{
    double max = pile[0];
    double min = pile[0];

    for (int i = 0; i < pile.Length; i++)
    {
        if (pile[i] > max)
        {
            max = pile[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива равен {Math.Round(max, 2)}");

    for (int i = 0; i < pile.Length; i++)
    {
        if (pile[i] < min)
        {
            min = pile[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива равен {Math.Round(min, 2)}");
    Console.WriteLine();

    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(diff, 2)}");
}

Console.Write("Введи размер массива: ");
int s = Convert.ToInt32(Console.ReadLine()); // переменная s задаёт размер массива
double[] array = new double[s];

SetArray(array);
PrintArray(array);
MaxMinDifference(array);

Console.ReadLine();