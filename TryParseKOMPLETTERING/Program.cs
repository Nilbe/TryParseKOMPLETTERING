int answer = 0;

bool stringToInt = false;

while(stringToInt != true)
{
    Console.WriteLine("What is 1+1?");
    Console.WriteLine("Enter your answer");
    string input = Console.ReadLine();

    stringToInt = int.TryParse(input, out answer);
}

if(stringToInt == true)
{
    if(answer == 2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("False!");
    }

    Console.WriteLine("Press Enter to close");
}

Console.ReadLine();