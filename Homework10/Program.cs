// Напишите цикл, который принимает на вход 2 числа А и В и возводит число А в натуральную степень В.
//Запрашиваем данные от пользователя и парсим их
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


//Вычисляем степень числа и выводим ответ:

void Conculate()
{
    int result=1;
    for (int i=0; i<b; i++ )
    {
        result*=a;
    }
    Console.WriteLine(result);
}

Conculate ();







