void SetArray(int[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        variety[index] = new Random().Next(-999, 1000); // [-999, 1000)
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
    }
    Console.Write(" ]");
    Console.WriteLine();
}

void SumOfElements(int[] pile)
{
    int sum = 0;
    int parity;

    for (int ind = 1; ind < pile.Length; ind++)
    {
        parity = ind % 2;

        if (parity == 1)
        {
            sum = sum + pile[ind];
        }
    }
    Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {sum}. ");
}

Console.Write("Введи размер массива: ");
int s = Convert.ToInt32(Console.ReadLine()); // переменная s задаёт размер массива
int[] array = new int[s];

SetArray(array);
PrintArray(array);
SumOfElements(array);
Console.ReadLine();