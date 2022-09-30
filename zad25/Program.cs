int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {

            Console.WriteLine($"Вы ввели число: {number}");

            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число. \nВведите число ещё раз: ");
        }
    }
}

Console.Write("Введите число A: ");
int numberA = InNumber();

Console.Write("Введите число B: ");
int numberB = InNumber();

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}

Console.Write(result);
