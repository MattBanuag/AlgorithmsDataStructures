// Program Setup
using System.Numerics;
int wordCount;
int inputTries = 5;

// How many words - PROMPT
Console.WriteLine("~ How many words would you like to check?");
string countInput = Console.ReadLine();

// Validation
bool result = int.TryParse(countInput, out wordCount);
do
{
    if (!result && inputTries > 0)
    {
        inputTries--;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: '{countInput}' is not a number. Please enter a number: ");
        countInput = Console.ReadLine();
    }
    else if (inputTries == 0)
    {
        Console.WriteLine();
        Console.WriteLine($"ERROR: You have reached the maximum amount of tries. Hit <enter> to try again");
        Console.ReadLine();
        return;
    }
    else
    {
        inputTries = -1;
    }
} while (inputTries > -1);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

// What are the words - PROMPT
Console.WriteLine("~ Which words would they be?");
Console.WriteLine("~ NOTE: Please press <enter> after every word.");
// Initializing array and passing values
string[] wordsArray = new string[wordCount];
for (int i = 0; i < wordCount; i++)
{
    wordsArray[i] = Console.ReadLine();

    // Validation
    if (wordsArray[i].Contains(" "))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Words cannot contain a space. Hit <enter> to try again.");
        Console.ReadLine();
        return;
    }
    else if (wordsArray[i] == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Words cannot be empty. Hit <enter> to try again.");
        Console.ReadLine();
        return;
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

// Entering a character - PROMPT
Console.WriteLine("~ Please enter a character to count its occurence:");
char character = char.ToLower(Console.ReadKey().KeyChar);
inputTries = 5;

// Validation
do
{
    if (!Char.IsLetter(character) && inputTries > 0)
    {
        inputTries--;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine($"ERROR: '{character}' is not a letter. Please select a letter: ");
        character = char.ToLower(Console.ReadKey().KeyChar);
    }
    else if (inputTries == 0)
    {
        Console.WriteLine();
        Console.WriteLine($"ERROR: You have reached the maximum amount of tries. Hit <enter> to try again");
        Console.ReadLine();
        return;
    } else
    {
        inputTries = -1;
    }
} while (inputTries > -1);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int occurenceCount = 0;
string joinedWords = String.Join("", wordsArray).ToLower();

foreach(char c in joinedWords)
{
    if(c == character)
    {
        occurenceCount++;   
    }  
}

// Result Summary
double characterPercentage = ((double)occurenceCount / (double)joinedWords.Length) * 100;
Console.WriteLine();
Console.WriteLine($"~ '{character}' is seen {occurenceCount} times in the array");
Console.WriteLine($"~ '{character}' makes up {characterPercentage}% of the array");
Console.ReadLine();














