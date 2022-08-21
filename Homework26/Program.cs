// Напишите программу, которая выдает натуральные числа от 1 до N
Console.Clear();
int number = ReadData("Задайте число: ");
//Метод общения с пользователем
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}



//Метод самой рекурсии
int NuturalNumberPrinter(int num)
{
    //остановка рекурсии
    if (num == 1)
    {
        Console.Write(1);
        return 1;
    }
    //рекурсия
    else
    {
        Console.WriteLine(num + " ");
        num = NuturalNumberPrinter(num - 1);
    }
    return num;
}

NuturalNumberPrinter(number);