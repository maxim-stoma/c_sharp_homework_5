void SetArray(int[] variety)
{
    for (int index = 0; index < variety.Length; index++)
    {
        variety[index] = new Random().Next(100, 1000); // [100, 1000)
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
}

void ParityElements(int[] pile)
{
    int count = 0;
    int parity;
    Console.WriteLine();

    for (int ind = 0; ind < pile.Length; ind++)
    {
        parity = pile[ind] % 2;

        if (parity == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Итак, количество чётных чисел равно {count}. ");
}

Console.Write("Введи размер массива: ");
int s = Convert.ToInt32(Console.ReadLine()); // переменная s задаёт размер массива
int[] array = new int[s];

SetArray(array);
PrintArray(array);
ParityElements(array);
Console.ReadLine();