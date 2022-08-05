Console.WriteLine ("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());
int t;

void VariantSimple()
{
    int SumOfNumbers =0;
    for (int i=1; i<=inputNumber; i++)
    {
        SumOfNumbers+=i;
        //или
        //SumOfNumbers=SumOfNumbers+i;
    }
    Console.WriteLine ("Сумма чисел от 1 до "+ inputNumber + "="+SumOfNumbers);
}
//Вариант 2
void VariantGauss()
{
  int SumOfNumbers =0;
  SumOfNumbers=((1+inputNumber)*inputNumber)/2;  
  Console.WriteLine ("Сумма чисел от 1 до "+ inputNumber + "="+SumOfNumbers);
}
t=Environment.TickCount;
VariantSimple();
Console.WriteLine ("Simple time: {0} ms", Environment.TickCount-t);
VariantGauss();

