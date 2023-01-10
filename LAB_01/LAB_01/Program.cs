// How many words - PROMPT
Console.WriteLine("How many words would you like to check?");
int wordCount = Int32.Parse(Console.ReadLine());

// What are the words - PROMPT
Console.WriteLine("Which words would they be?");
Console.WriteLine("NOTE: Please press <enter> after every word.");
// Initializing array and passing values
string[] wordsArray = new string[wordCount];
for (int i = 0; i < wordCount; i++)
{
    wordsArray[i] = Console.ReadLine();
}

// Entering a character - PROMPT
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Please enter a character:");
char character = Char.Parse(Console.ReadLine());










