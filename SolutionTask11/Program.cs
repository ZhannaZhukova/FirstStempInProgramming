//1 Вариант
//int number=new Random().Next(100,1000);
//Console.WriteLine("Число: "+number);
//int numberSecondDigit=number/100;
//int numberThirdDigit=number%10;
//Console.WriteLine("Число после удаления второй цифры: "+numberSecondDigit+numberThirdDigit);

//2 Вариант
void middleDiggitCutter()
{
    int number=new Random().Next(100,1000);
    Console.Write("The random number is ");
    Console.WriteLine(number);
    string stringNum=number.ToString();
    Console.Write("The modified number is ");
    Console.Write(stringNum[0]);
    Console.Write(stringNum[1]);
}

middleDiggitCutter();
