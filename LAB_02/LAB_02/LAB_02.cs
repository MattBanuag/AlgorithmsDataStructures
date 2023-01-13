/*
    A program that produces an array of all of the characters that 
    appear more than once in a string.

    For example, the string “Programmatic Python” would result in 
    the array ['p','r','o','a','m','t'].
*/
/*Console.WriteLine("~ Please enter a word of at LEAST 15 characters: ");
string userInput = Console.ReadLine();
string formattedInput = userInput.ToLower();
char[] charsList = formattedInput.ToCharArray();
char[] repeatedChars;

for(int i = 0; i < charsList.Length; i++)
{
    if (charsList.Contains(formattedInput[i]) && formattedInput.Count() )
    {
        Console.WriteLine(formattedInput[i]);

    }
}*/

/*
    A program that reverses a provided string  
*/
using System.Diagnostics.Tracing;

Console.WriteLine("~ Reversing string");
Console.WriteLine("~ Please enter a word: ");
string reversedWord = "";
string userInputString3 = Console.ReadLine();
char[] charsList3 = userInputString3.ToCharArray();

for(int i = charsList3.Length - 1; i >= 0; i--)
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
Console.WriteLine("~ Longest unbroken word");
Console.WriteLine("~ Please enter a sentence: ");
string userInputString4 = Console.ReadLine();
userInputString4.ToLower();
string[] wordsArray = userInputString4.Split(" ");

string currentWord = "";
int currentLength = 0;
foreach(string word in wordsArray)
{
    if(word.Length > currentLength)
    {
        currentWord = word;
        currentLength = word.Length;
    }    
}

Console.WriteLine(currentWord);
