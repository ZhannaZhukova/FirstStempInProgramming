// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Clear();
//Запрашиваем данные у пользователя
int numberM = ReadData("Задайте положительное число M");
int numberN = ReadData("Задайте положительное число N");

//Метод считывания данных и парсинга
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}
// функция Аккермана
int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
Console.WriteLine(A(numberN, numberM));