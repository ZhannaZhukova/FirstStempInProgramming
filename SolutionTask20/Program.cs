// Метод ввода данных от пользователя (считывает координаты точек А,В)
int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lenghtAB;
void readDataOfPoin ()
{
    Console.WriteLine("Введите координату Х точки А");
    coordXPointA=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXPointB=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB=int.Parse (Console.ReadLine());
}

//Вычисляет расстояние между А,В
void conculateLenghtAB()
{
    lenghtAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB),2) + Math.Pow ((coordYPointA-coordYPointB),2));

}

readDataOfPoin ();
conculateLenghtAB();
 Console.WriteLine (lenghtAB);