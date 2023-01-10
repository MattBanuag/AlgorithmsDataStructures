// How many words - PROMPT
Console.WriteLine("~ How many words would you like to check?");
int wordCount = Int32.Parse(Console.ReadLine());
Console.WriteLine();

// What are the words - PROMPT
Console.WriteLine("~ Which words would they be?");
Console.WriteLine("~ NOTE: Please press <enter> after every word.");
// Initializing array and passing values
string[] wordsArray = new string[wordCount];
for (int i = 0; i < wordCount; i++)
{
    wordsArray[i] = Console.ReadLine();
}
Console.WriteLine();

// Entering a character - PROMPT
Console.WriteLine("~ Please enter a character:");
char character = Console.ReadKey().KeyChar;
int occurenceCount = 0;
int totalCharCount = 0;
Console.WriteLine();

for(int i = 0; i < wordsArray.Length; i++)
{
    foreach(char c in wordsArray[i])
    {
        if(c == character)
        {
            occurenceCount++;
        }
        totalCharCount++;
    }
}

// Result Summary
double characterPercentage = ((double)wordCount / (double)totalCharCount) * 100;
Console.WriteLine();
Console.WriteLine($"~ '{character}' is seen {occurenceCount} times in the array");
Console.WriteLine($"~ '{character}' makes up {characterPercentage}% of the array");
Console.ReadLine();














