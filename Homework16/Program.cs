// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write ("Введите элементы через пробел: ");
int [] inputArray = Array.ConvertAll (Console.ReadLine().Split(), int.Parse);
int count =0;
void Conculate()
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine ("Количество элементов >0: " +count);
}
Conculate();
