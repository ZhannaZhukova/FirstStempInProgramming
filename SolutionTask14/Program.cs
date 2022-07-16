string?inputLineOne=Console.ReadLine();

if (inputLineOne!=null)
{
    int num=int.Parse(inputLineOne);
    
    if(num%7==0&&num%23==0)
    {
        Console.WriteLine("кратно");
    }
    else{
        Console.WriteLine("не кратно");
    }
}