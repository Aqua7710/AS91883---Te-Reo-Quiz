int selection; // variable for selection
               //introduction 
StartingPoint: // will bring user back to this point if they choose to at the end of the quiz
Console.WriteLine("Kia Ora user! Welcome to this Te Reo Māori quiz.");
Console.WriteLine("This quiz will test your Te Reo Māori knowlege by asking you 10 multichoice questions. You will only have one try to get the question right. After you answer these questions, the program will calculate and display your skill level.");

//quiz level selector
Console.WriteLine("\n\nDifficulty level:");
Console.WriteLine("\n\n1 = Beginner" + "\n\n2 = Intermediate" + "\n\n3 = Advanced");
Console.Write("\n\nPlease choose a difficulty level by typing the number next to the level you would like to do and then press enter: ");
while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >= 4)
{
    Console.Write("\nPlease only enter a valid number option: ");
}
int beginnerQuiz, score = 0;
string I = "Incorrect!", C = "Correct!";

// beginner quiz

if (selection == 1)
{
    Console.Clear(); // clears all the text that came before so that it's easier to focus
    Console.WriteLine("You chose the Beginner quiz! Begin answering the questions.\n\n");

    // question 1, beginner
    Console.WriteLine("Question 1) How do you say 'Hello' in Māori?");
    Console.WriteLine("\n\n1 = kia ngahau" + "\n\n2 = whakakatakata" + "\n\n3 = Kia Ora" + "\n\n4 = po pai");
    Console.Write("\nYour answer (select an answer by typing the number next to the option you pick and then press enter) = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 3:
            Console.Clear();
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 2, beginner
    Console.WriteLine("\n\nQuestion 2) How do you say 'Goodbye all' in Māori?");
    Console.WriteLine("\n\n1 = Tahi" + "\n\n2 = kia ora katoa" + "\n\n3 = i tenei ra" + "\n\n4 = apopo");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 3, beginner
    Console.WriteLine("\n\nQuestion 3) What is the correct order of 1, 2, 3 in Māori?");
    Console.WriteLine("\n\n1 = Rua, Tahi, Toru" + "\n\n2 = Toru, Rua, Tahi" + "\n\n3 = Tahi, Rua, Toru");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 4)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (beginnerQuiz)
    {

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 4, beginner
    Console.WriteLine("\n\nQuestion 4) How do you say 'my name is..' in Māori?");
    Console.WriteLine("\n\n1 = ko toku ingoa" + "\n\n2 = te ata pai" + "\n\n3 = he roroa ahau" + "\n\n4 = he roroa ahau");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 5, beginner
    Console.WriteLine("\n\nQuestion 5) How do you say 'female' in Māori?");
    Console.WriteLine("\n\n1 = tane" + "\n\n2 = wahine" + "\n\n3 = tamaiti" + "\n\n4 = whaea");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 6, beginner
    Console.WriteLine("\n\nQuestion 6) True or false, 'kei te pehea koe' means 'I am well'?");
    Console.WriteLine("\n\n1 = True" + "\n\n2 = False");
    Console.Write("\nYour answer = ");

    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (beginnerQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;
        
        default:
            Console.Clear();
            Console.WriteLine("Incorrect! It means 'how are you'");
            break;
    }
    // question 7, beginner
    Console.WriteLine("\n\nQuestion 7) How do you say 'good' in Māori?");
    Console.WriteLine("\n\n1 = kino" + "\n\n2 = pai" + "\n\n3 = te ua" + "\n\n4 = puawai");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 8, beginner
    Console.WriteLine("\n\nQuestion 8) How do you say 'mountain' in Māori?");
    Console.WriteLine("\n\n1 = kēmu" + "\n\n2 = rakau" + "\n\n3 = awa" + "\n\n4 = maunga");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 9, beginner
    Console.WriteLine("\n\nQuestion 9) How do you say 'family' in Māori?");
    Console.WriteLine("\n\n1 = teina" + "\n\n2 = hoa" + "\n\n3 = whanau" + "\n\n4 = tuahine");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 10, beginner
    Console.WriteLine("\n\nQuestion 10) How do you say 'food' in Māori?");
    Console.WriteLine("\n\n1 = oumu" + "\n\n2 = kīhini" + "\n\n3 = ahi" + "\n\n4 = kai");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out beginnerQuiz) || beginnerQuiz <= 0 || beginnerQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (beginnerQuiz)
    {
        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            Console.WriteLine("---------------------------------------------------------"); // used to sperate the final correct/incorrect message from the final score
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            Console.WriteLine("---------------------------------------------------------"); // used to sperate the final correct/incorrect message from the final score
            break;
    }
    // finish beginner quiz
    Console.WriteLine("\n\n\nCongratulations! You have completed the beginner level Te Reo Māori quiz!");
    // display different result depending on score
    if (score <= 3)
    {
        Console.WriteLine($"\n\nYou got {score}/10. Good try, but you need more practice.");
    }
    else if (score <= 7)
    {
        Console.WriteLine($"\n\nYou got {score}/10. You did good, practice a little bit more to aim for a higher score!");
    }
    else if (score <= 9)
    {
        Console.WriteLine($"\n\nYou got {score}/10. SO CLOSE! Keep trying!");
    }
    else
    {
        Console.WriteLine($"\n\nYou got {score}/10. PERFECT SCORE!");
    }
    int reDo;   // variable for repeat

    Console.Write("\n\nWould you like to take another quiz? Type '1' for Yes or type '2' for No = "); // I added 'press 2 for no' option to make sure that the user doesn't accidentaly exit the quiz
    while (!int.TryParse(Console.ReadLine(), out reDo) || reDo <= 0 || reDo >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (reDo)
    {
        case 1:
            Console.Clear();
            goto StartingPoint; // allows user to redo the quiz or pick another quiz

        default:
            Console.WriteLine("\n\n\nThank you for particapating in this quiz!\n\n-------------------------------------------------------------"); // end message and line used to seperate final message from the other code
            break;
    }
}
// intermediate quiz
int intermediateQuiz;

if (selection == 2)
{
    Console.Clear();
    Console.WriteLine("You chose the Intermediate quiz! Begin answering the questions.\n\n");

    // question 1, intermediate
    Console.WriteLine("Question 1) How do you say 'ocean' in Māori?");
    Console.WriteLine("\n\n1 = whenua" + "\n\n2 = rakau" + "\n\n3 = moana" + "\n\n4 = rangi");
    Console.Write("\nYour answer (select an answer by typing the number next to the option you pick and then press enter) = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {   
            Console.Write("\nPlease only enter a valid number option: ");       
    }

    switch (intermediateQuiz)
    {

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 2, intermediate
    Console.WriteLine("\n\nQuestion 2) True or false, 'I am going' is 'kei te haere ahau' in Māori?");
    Console.WriteLine("\n\n1 = True" + "\n\n2 = False");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 3, intermediate
    Console.WriteLine("\n\nQuestion 3) What is 'He pai ahau' in english?");
    Console.WriteLine("\n\n1 = I am tall" + "\n\n2 = You are short" + "\n\n3 = They are fun" + "\n\n4 = I am good");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 4, intermediate
    Console.WriteLine("\n\nQuestion 4) How do you say 'house' in Māori?");
    Console.WriteLine("\n\n1 = rorohiko" + "\n\n2 = whare" + "\n\n3 = teneti" + "\n\n4 = hotera");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {

        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 5, intermediate
    Console.WriteLine("\n\nQuestion 5) What is the correct order of 8, 9, 10 in Māori?");
    Console.WriteLine("\n\n1 = ono, waru, iwa" + "\n\n2 = iwa, tahi, rua" + "\n\n3 = waru, iwa, tekau");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 4)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;
    }
    // question 6, intermediate
    Console.WriteLine("\n\nQuestion 6) What option is the correct Māori vowels?");
    Console.WriteLine("\n\n1 = a, e, i, o, u" + "\n\n2 = a, e, i, o, u, p" + "\n\n3 = a, e, i, o, u, y" + "\n\n4 = a, e, i, o, u, t");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            ++score;
            break;

        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

    }
    // question 7, intermediate
    Console.WriteLine("\n\nQuestion 7) What is 'Kaumatu' in English?");
    Console.WriteLine("\n\n1 = Elder" + "\n\n2 = Sister" + "\n\n3 = Brother" + "\n\n4 = Mother");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

    }
    // question 8, intermediate
    Console.WriteLine("\n\nQuestion 8) What is 'Auckland' in Māori?");
    Console.WriteLine("\n\n1 = Ōtautahi" + "\n\n2 = Te Whanganui-a-Tara" + "\n\n3 = Aotearoa" + "\n\n4 = Tāmaki Makaurau");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

    }
    // question 9, intermediate
    Console.WriteLine("\n\nQuestion 9) Which number is bigger in Māori, 'rima tekau' or 'rima tekau ma ono'?");
    Console.WriteLine("\n\n1 = rima tekau" + "\n\n2 = rima tekau ma ono");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {
        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

    }
    // question 10, intermediate
    Console.WriteLine("\n\nQuestion 10) Which number is 'learning' in Māori?");
    Console.WriteLine("\n\n1 = rorohiko" + "\n\n2 = whare pukapuka" + "\n\n3 = whakaako" + "\n\n4 = ako");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out intermediateQuiz) || intermediateQuiz <= 0 || intermediateQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (intermediateQuiz)
    {

        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.WriteLine("---------------------------------------------------------"); // used to sperate the final correct/incorrect message from the final score
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            Console.WriteLine("---------------------------------------------------------"); // used to sperate the final correct/incorrect message from the final score
            break;

    }
    // finish intermediate quiz
    Console.WriteLine("\n\n\nCongratulations! You have completed the intermediate level Te Reo Māori quiz!");
    // display different result depending on score
    if (score <= 3)
    {
        Console.WriteLine($"\n\nYou got {score}/10. Good try, but you need more practice.");
    }
    else if (score <= 7)
    {
        Console.WriteLine($"\n\nYou got {score}/10. You did good, practice a little bit more to aim for a higher score!");
    }
    else if (score <= 9)
    {
        Console.WriteLine($"\n\nYou got {score}/10. SO CLOSE! Keep trying!");
    }
    else
    {
        Console.WriteLine($"\n\nYou got {score}/10. PERFECT SCORE!");
    }
    int reDo;   // variable for repeat

    Console.Write("\n\nWould you like to take another quiz? Type '1' for Yes or type '2' for No = ");
    while (!int.TryParse(Console.ReadLine(), out reDo) || reDo <= 0 || reDo >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (reDo)
    {
        case 1:
            Console.Clear();
            goto StartingPoint; // allows user to redo the quiz or pick another quiz

        default:
            Console.WriteLine("\n\n\nThank you for particapating in this quiz!\n\n-------------------------------------------------------------"); // end message
            break;
    }
}


// advanced quiz
int advancedQuiz;

if (selection == 3)
{
    Console.Clear(); // clears all the text that came before so that it's easier to focus
    Console.WriteLine("You chose the Advanced quiz! Begin answering the questions.\n\n");

    // question 1, advanced
    Console.WriteLine("Question 1) Which one is 'please and thank you' in Māori?");
    Console.WriteLine("\n\n1 = tēnā koa" + "\n\n2 = tēnā koe, tēnā koe" + "\n\n3 = tēnā koa, tēnā koa" + "\n\n4 = pouri");
    Console.Write("\nYour answer (select an answer by typing the number next to the option you pick and then press enter) = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 2, advanced
    Console.WriteLine("Question 2) What does 'te maunga me nga awa' translate to in English?");
    Console.WriteLine("\n\n1 = the family gathering" + "\n\n2 = school is big" + "\n\n3 = the town and the city" + "\n\n4 = the mountain and rivers");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 4:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 3, advanced
    Console.WriteLine("Question 3) How do you say 'the house is big' in Māori?");
    Console.WriteLine("\n\n1 = he nui te whare" + "\n\n2 = he iti te whare" + "\n\n3 = kei te hanga whare ahau" + "\n\n4 = kei te noho ahau ki tetahi whare");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 4, advanced
    Console.WriteLine("Question 4) True or false, 'ruma rorohiko' translates to library in English?");
    Console.WriteLine("\n\n1 = True" + "\n\n2 = False");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;
    }
    // question 5, advanced
    Console.WriteLine("Question 5) What does 'ko te tangi te waea' translate to in English?");
    Console.WriteLine("\n\n1 = the computer is loud" + "\n\n2 = I am going now" + "\n\n3 = the telephone is ringing" + "\n\n4 = it's time to go");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;
    }
    // question 6, advanced
    Console.WriteLine("Question 6) How do you say 'I am going now' in Māori?");
    Console.WriteLine("\n\n1 = te rererangi" + "\n\n2 = kei konei ahau" + "\n\n3 = kei te haere ahau inaianei" + "\n\n4 = e hiahia ana koe ki te haere mai i ahau");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 7, advanced
    Console.WriteLine("Question 7) How do you say 'how are you today?' in Māori?");
    Console.WriteLine("\n\n1 = kei te pehea koe i tenei ra?" + "\n\n2 = kei te haere mai koe i tenei ra?" + "\n\n3 = he roroa koe?" + "\n\n4 = kei te tata koe?");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;

    }
    // question 8, advanced
    Console.WriteLine("Question 8) Which Māori number is the smallest?");
    Console.WriteLine("\n\n1 = miriona" + "\n\n2 = Rau" + "\n\n3 = rau mano");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 4)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 2:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 9, advanced

    Console.WriteLine("Question 9) How do you say 'the dog in the park' in Māori?");
    Console.WriteLine("\n\n1 = te kuri i te papa" + "\n\n2 = ka oma tawhiti te kuri" + "\n\n3 = noho te ngeru i runga i te moenga" + "\n\n4 = he nui te hoiho");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {
        case 1:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.Beep();
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            break;
    }
    // question 10, advanced
    Console.WriteLine("Question 10) What is 'ka rere te poti' in English?");
    Console.WriteLine("\n\n1 = the computer was hot" + "\n\n2 = the car drove" + "\n\n3 = the boat sailed" + "\n\n4 = the ship sank");
    Console.Write("\nYour answer = ");
    while (!int.TryParse(Console.ReadLine(), out advancedQuiz) || advancedQuiz <= 0 || advancedQuiz >= 5)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }

    switch (advancedQuiz)
    {

        case 3:
            Console.Clear(); 
            Console.WriteLine(C);
            Console.WriteLine("---------------------------------------------------------");
            ++score;
            break;

        default:
            Console.Clear();
            Console.WriteLine(I);
            Console.WriteLine("---------------------------------------------------------");
            break;
    }
    // finish advanced quiz
    Console.WriteLine("\n\n\nCongratulations! You have completed the advanced level Te Reo Māori quiz!");
    // display different result depending on score
    if (score <= 3)
    {
        Console.WriteLine($"\n\nYou got {score}/10. Good try, but you need more practice.");
    }
    else if (score <= 7)
    {
        Console.WriteLine($"\n\nYou got {score}/10. You did good, practice a little bit more to aim for a higher score!");
    }
    else if (score <= 9)
    {
        Console.WriteLine($"\n\nYou got {score}/10. SO CLOSE! Keep trying!");
    }
    else
    {
        Console.WriteLine($"\n\nYou got {score}/10. PERFECT SCORE!");
    }
    int reDo;   // variable for repeat

    Console.Write("\n\nWould you like to take another quiz? Type '1' for Yes or type '2' for No = ");
    while (!int.TryParse(Console.ReadLine(), out reDo) || reDo <= 0 || reDo >= 3)
    {
        Console.Write("\nPlease only enter a valid number option: ");
    }
    switch (reDo)
    {
        case 1:
            Console.Clear();
            goto StartingPoint; // allows user to redo the quiz or pick another quiz

        default:
            Console.WriteLine("\n\n\nThank you for particapating in this quiz!\n\n-------------------------------------------------------------"); // end message
            break;
    }
}