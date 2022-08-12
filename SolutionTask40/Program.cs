// напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle();
PrintAnswer(res);

void ReadSides()
{
    Console.Write("Введите число 1 ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 2 ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3 ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

bool TestTriangle()
{
    bool answer = ((sideA+sideB>sideC)
    &&(sideB+sideC>sideA)
    &&(sideA+sideC>sideB)) ? true:false;
    //переменная= (условие)? значение 1:значение 2;
    //тринарный оператор
    return answer;
}

void PrintAnswer (bool answer)
{
    if (answer)
    {
        Console.WriteLine ("Из этих отрезков можно составить треугольник");
    }
    else
    {
        Console.WriteLine ("Из этих отрезков нельзя составить треугольник");
    }
}
