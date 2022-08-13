// Не используя рекурсию, выведите первые N чисел Фибоначчи
//первые числа:0,1
//fn-1+fn-2=fn
Console.Write("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber ();
string outline = Fibonacci (decemalNumber);
PrintAnswer (outline);
int i=0;

int ReadDecemalNumber ()
{
    return int.Parse(Console.ReadLine() ?? "");
}

string Fibonacci(int n)
{
    string answer = "";
    if (n == 2)
    {
        answer = "0 1";
    }
    else if (n == 1)
    {
        answer = "0";
    }
    else
    {
        answer = "0 1";
        int last =1;
        int secondlast  =0;
        int current;
        for (i= 0; i<n-2; i++)
        {
         current = last + secondlast;
         answer +=" " + current;
         secondlast = last;
         last = current;
        }
            
    }
    return answer;  
}

void PrintAnswer(string answer){
    Console.WriteLine ("Ряд Фибоначчи для заданного количества чисел: "+ answer);
}