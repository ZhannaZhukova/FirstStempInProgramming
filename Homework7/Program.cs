//Программа, которая принимает на вход координаты 2 точек и находит расстояние между ними в 3D пространстве.
int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lenghtAB;

// Метод ввода данных от пользователя (считывает координаты точек А,В)
void readDataOfPoin ()
{
    Console.WriteLine("Введите координату Х точки А");
    coordXPointA=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Z точки А");
    coordZPointA=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXPointB=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB=int.Parse (Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZPointB=int.Parse (Console.ReadLine());
}

//Вычисляет расстояние между А,В
void conculateLenghtAB()
{
    lenghtAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB),2) + Math.Pow ((coordYPointA-coordYPointB),2)+ Math.Pow ((coordZPointA-coordZPointB),2));

}

readDataOfPoin ();
conculateLenghtAB();
 Console.WriteLine (lenghtAB);
