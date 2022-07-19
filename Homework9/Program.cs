//Программа, которая принимает на вход 5-значное число и проверяет, является ли оно палиндромом
//Запрашиваем данные от пользователя
Console.WriteLine ("введите пятизначное число");
string? inputLine=Console.ReadLine();
//Парсим переменную inputLine
int inputNumber = int.Parse (inputLine);

int digit1;
int digit2;
int digit3;
int digit4;
int digit5;
//определяем 1,2,3,4,5 цифры числа 
void digits ()
{
    digit1 = inputNumber/10000;
    digit2 = (inputNumber/1000)%10;
    digit3 = (inputNumber/100)%10;
    digit4 = (inputNumber/10)%10;
    digit5 = inputNumber%10;
}
digits ();
//Задаем условие и выводим ответ 
if ((digit1==digit5)&&(digit2==digit4))
{
    Console.WriteLine ("Палиндром");
}
else
{
    Console.WriteLine ("Не палиндром");
}