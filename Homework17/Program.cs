//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int k1 = 0; int k2 = 0;
int b1 = 0; int b2 = 0;
int x=0; int y=0;
//Метод, считывающий данные и парсящий их
void ReadLine()
{
    Console.Write ("Введите k1: ");
    k1 = int.Parse (Console.ReadLine());
    Console.Write ("Введите k2: ");
    k2 = int.Parse (Console.ReadLine());
    Console.Write ("Введите b1: ");
    b1 = int.Parse (Console.ReadLine());
    Console.Write ("Введите b2: ");
    b2 = int.Parse (Console.ReadLine());
}
//Метод, вычисляющий значение х,у
void Conculate()
{
    
    x=(b2-b1)/(k1-k2);
    y = k1*x+b1;
}
//Выводим на печать ответ
void Print ()
{
    Console.WriteLine("Пересечение в точке: "+x,+y);
}
ReadLine();
Conculate();
Print();