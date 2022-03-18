// See https://aka.ms/new-console-template for more information
int selection, q1d1;
//introduction 

Console.WriteLine("Kia Ora user! Welcome to this Te Reo Maori quiz.");
Console.WriteLine("This quiz will test your Te Reo Maori knowlege by asking you 15 multichoice questions. After you answer these questions, the program will calculate and display your skill level.");

//quiz level selector
Console.WriteLine("\n\nDifficulty level:");
Console.WriteLine("\n\n1 = Beginner" + "\n\n2 = Intermediate" + "\n\n3 = Advanced");
Console.Write("\n\nPlease choose a difficulty level by typing the number next to the level you would like to do:");
while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >= 4)
{
    Console.Write("\nPlease only enter a valid number option: ");
}
switch (selection)
{
    case 1:
        Console.WriteLine("\n\nYou choose the Beginner quiz! Begin answering the questions.");
        Console.Write("\n\nQuestion 1: How do you say 'hello' in Maori?");
        Console.WriteLine("\n\n1) Haere rā \n2) Tēnā koe \n3) Kia Ora \n4) Tēnā koutou");
        q1d1 = Convert.ToInt32(Console.ReadLine());
        break;

    case 2:
        Console.WriteLine("\n\nYou choose the Intermediate quiz! Begin answering the questions.");
        break;

    case 3:
        Console.WriteLine("\n\nYou choose the Advanced quiz! Begin answering the questions.");
        break;
}







