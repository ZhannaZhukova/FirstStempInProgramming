
//Метод решения задачи вариант 1
void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10, 100);
    //1 Вариант
    Console.WriteLine(number);
    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}
//Метод решения задачи вариант 2
void variant2()
{
    //2 вариант
    int numberKirilla = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(numberKirilla);
    string stringNum = numberKirilla.ToString();

    Console.Write("The biggest digit is: ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}
//Метод решения задачи вариант 3
void variant3(System.Random numberSintezator)
{
    //3 вариант
    Char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();
    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0]) - 48;
    int secondNumber = ((int)digits[1]) - 48;

    int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;
    Console.WriteLine(resultNumber);

}

System.Random numberSintezator = new Random();
variant1(numberSintezator);
variant2 ();
variant3(numberSintezator);
