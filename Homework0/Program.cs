string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
if(inputLineOne !=null && inputLineTwo !=null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);

    if(inputNumberOne > inputNumberTwo)
    {
        Console.WriteLine (inputNumberOne);        
    }
    else{
        Console.WriteLine (inputNumberTwo);
    }
}

