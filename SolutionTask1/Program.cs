string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
if(inputLineOne !=null && inputLineTwo !=null){
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);

    if(inputNumberTwo == Math.Sqrt(inputNumberOne))
    {
        Console.WriteLine ("yes");        
    }
    else{
        Console.WriteLine ("no");
    }
}

