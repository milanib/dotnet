// See https://aka.ms/new-console-template for more information
List<int> myNumberList = new List<int>(){
                2, 3, 5, 6, 7, 9, 10, 123, 324, 54, 30
            };
myNumberList.Sort();
//Write Your Code Here

foreach (int i in myNumberList)
{
    if ((i % 2 == 0) && (i % 3 == 0))
    {
        Console.WriteLine("Both even and divisible by Three:" + i);
    }
    else if ((i % 2 == 0))
    {
        Console.WriteLine("Even: " + i);
    }
    else if ((i % 3 == 0))
    {
        Console.WriteLine("Divisible by three: " + i);
    }
    else
    {
        Console.WriteLine("Odd and not divisble by threes " + i);
    }
}
