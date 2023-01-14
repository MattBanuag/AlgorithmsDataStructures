/*
    A program that produces an array of all of the characters that 
    appear more than once in a string.

    For example, the string “Programmatic Python” would result in 
    the array ['p','r','o','a','m','t'].
*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("~ Getting repeated characters in a string: ");
Console.WriteLine("~ Please enter 2 words with repeated characters: ");
Console.ForegroundColor = ConsoleColor.White;
string userInput = Console.ReadLine();
string formattedInput = userInput.ToLower();
char[] charArray = formattedInput.ToCharArray();
string repeatingChars = "";

for (int i = 0; i < charArray.Length; i++)
{
    int indexOfFirst = Array.IndexOf(charArray, charArray[i]);
    int indexOfSecond = Array.LastIndexOf(charArray, charArray[i]);

    if (indexOfFirst != indexOfSecond)
    {
        repeatingChars += charArray[i];
    }
}

string finalResult = "";
foreach (char c in repeatingChars)
{
    if (finalResult.IndexOf(c) == -1)
    {
        finalResult += c;
    }
}
char[] resultRepeatedChars = finalResult.ToCharArray();
foreach (char c in resultRepeatedChars)
{
    Console.Write($"[{c}] ");
}

Console.WriteLine();

/*
    A program returns an array of strings that are 
    unique words found in the argument.

    For example, the string “To be or not to be” 
    returns ["to","be","or","not"].
*/
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("~ Getting unique words from a string: ");
Console.WriteLine("~ Please enter a sentence with some repeated words: ");
Console.ForegroundColor = ConsoleColor.White;
string userInputString2 = Console.ReadLine();
string formattedString = userInputString2.ToLower();
string[] testStrings = formattedString.Split(" ");
string uniqueStrings = "";

for (int i = 0; i < testStrings.Length; i++)
{
    int indexOfFirst = Array.IndexOf(testStrings, testStrings[i]);
    int indexOfSecond = Array.LastIndexOf(testStrings, testStrings[i]);

    // Repeeating Strings
    if (uniqueStrings.IndexOf(testStrings[i]) == -1)
    {
        uniqueStrings += testStrings[i] + ",";
    }
}

string[] uniqueStringsArray = uniqueStrings.Split(",");

foreach (string str in uniqueStringsArray)
{
    Console.Write($"[{str}] ");
}

Console.WriteLine();

/*
    A program that reverses a provided string  
*/
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("~ Reversing string");
Console.WriteLine("~ Please enter a word: ");
Console.ForegroundColor = ConsoleColor.White;
string reversedWord = "";
string userInputString3 = Console.ReadLine();
char[] charsList3 = userInputString3.ToCharArray();

for (int i = charsList3.Length - 1; i >= 0; i--)
{
    reversedWord += charsList3[i];
}

Console.WriteLine(reversedWord);
Console.WriteLine();

/*
    A program that finds the longest unbroken word 
    in a string and prints it

    For example, the string "Tiptoe through the tulips" 
    would print "through" If there are multiple words tied 
    for greatest length, print the last one
*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("~ Longest unbroken word");
Console.WriteLine("~ Please enter a sentence: ");
Console.ForegroundColor = ConsoleColor.White;
string userInputString4 = Console.ReadLine();
userInputString4.ToLower();
string[] wordsArray = userInputString4.Split(" ");

string longestWord = "";
int nextIndex = 1;

for (int i = 0; i < wordsArray.Length; i++)
{
    if (wordsArray[i].Length >= wordsArray[nextIndex].Length)
    {
        longestWord = wordsArray[i];
    }
}

Console.WriteLine(longestWord);
