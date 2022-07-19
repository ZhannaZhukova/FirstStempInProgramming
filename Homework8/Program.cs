//Программа, которая принимает на вход число N и выводит таблицу кубов чисел от 1 до N
//Метод, который принимает данные от пользователя
string?inputLineN;
int numberN;
string lineN;
string lineNNN;
int s;
void readNumber ()
{
inputLineN=Console.ReadLine();
}
//Метод, который вычисляет кубы чисел от 1 до N и выводит ответ
void calculatePrintAnswer ()
{
if (inputLineN!=null)
{
    numberN= int.Parse(inputLineN);
    lineN="";
    lineNNN=string.Empty;
    s=1;
    while (s<=numberN)
    {
        lineN=lineN+s+" ";
        lineNNN=lineNNN+(s*s*s).ToString() + " ";
        s++;
    }

Console.WriteLine(lineN);
Console.WriteLine(lineNNN);
}

}

readNumber ();
calculatePrintAnswer ();