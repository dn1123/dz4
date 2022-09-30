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

int SumNumber(int numberN){

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

Console.Write("Введите число: ");

int numberN = InNumber();

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");