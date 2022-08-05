// Напишите программу, которая принимает на вход число и выдает сумму чисел в числе
//Запрашиваем данные пользователя и парсим их
string?a= Console.ReadLine();
int b = 0;
int numberA= int.Parse(a);
//Производим вычисления суммы чисел
void Conculate()
{
    while (numberA>0)
{
    b=b+numberA%10;
    numberA=numberA/10;
}
}
//Выводим результат
Conculate();
Console.WriteLine(b);