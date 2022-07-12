string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
string? inputLineThree = Console.ReadLine();
if(inputLineOne !=null && inputLineTwo !=null && inputLineThree !=null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);
    int inputNumberThree = int.Parse(inputLineThree);
    if (inputNumberOne>inputNumberTwo){
    if (inputNumberOne>inputNumberThree)
        Console.WriteLine (inputNumberOne);
        else{
            Console.WriteLine (inputNumberThree);
        }
    }
    else 
    {
        if(inputNumberTwo>inputNumberThree){
            Console.WriteLine(inputNumberTwo);
        }
        else 
        {
            Console.WriteLine(inputNumberThree);
        }
    }
}
        


   