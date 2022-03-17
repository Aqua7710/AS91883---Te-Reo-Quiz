// See https://aka.ms/new-console-template for more information
string selection;
//introduction 
Console.WriteLine("Hello there user! Welcome to this Te Reo Maori quiz.");
Console.WriteLine("This quiz will test your Te Reo Maori knowlege by asking you multichoice questions and word answer questions. After you answer these questions, the program will calculate and display your skill level.");
//quiz level selector
Console.WriteLine("\n\nWhich quiz mode would you like to try? Please type 'Beginner', 'Intermediate', or 'Advanced' depending on which quiz level you would like to take.");
selection = Convert.ToString(Console.ReadLine()); 
string selectionResult = selection.ToLower(); //converts the string that the user entered into lowercase so that it's easier to recongnize
if(selectionResult != "beginner" || selectionResult != "intermediate" || selectionResult != "advanced")
{

}
{
    if (selectionResult == "beginner" || selectionResult == "beginer" || selectionResult == "beginnner" || selectionResult == "begginer") 
    {
        Console.WriteLine("You choose Beginner");
    }
    else if (selectionResult == "intermediate" || selectionResult == "intermedtate" || selectionResult == "intermdiate" || selectionResult == "intermdiate")
    {
        Console.WriteLine("You choose Intermediate");
    }
    else if (selectionResult == "advanced")
    {
        Console.WriteLine("You choose Advanced");
    }
    else
    {
        Console.Write("You entered an invalid quiz type or you misspelt the name of the quiz level. Please try again.");
    }
}

