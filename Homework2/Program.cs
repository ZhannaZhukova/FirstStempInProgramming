string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse (inputLine);
       
    if(inputNumber%2==0)
    {
        Console.WriteLine ("четное");
    }
    else
    {
        Console.WriteLine ("нечетное");
    }
}

   