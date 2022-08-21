// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int sum = 0;
int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");

if (numberM < numberN)
{
    SumNaturalNamberPrinter(numberM, numberN);
}
else
{
    SumNaturalNamberPrinter(numberN, numberM);
}


int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}




int SumNaturalNamberPrinter(int m, int n)
{
    if (m - 1 == n) return m;
    sum = sum + m;
    SumNaturalNamberPrinter(m + 1, n);
    return sum;
}
Console.WriteLine(sum);
