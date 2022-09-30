int InNumber()
{
    while (true)
    {
        Console.Write("Введите число: ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число. ");
        }
    }
}

Console.WriteLine("Введите по очереди восемь цифр");


int [] numbers = new int[8];
for (int i =0; i <8; i++ )
{
    numbers [i] = InNumber();
}

//int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
   // numbers [i] = InNumber();
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
