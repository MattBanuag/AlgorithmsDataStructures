/*
    We have a list of integers where elements appear either once or twice. 
    Find the elements that appeared twice in O(n) time.

    example: {1, 2, 3, 4, 7, 9, 2, 4} returns {2, 4} 
*/

/*
    I believe that this program will run on O(n) time.
    There is only one loop iterating through the array.
*/
using System.Runtime.Intrinsics.Arm;
using System.Transactions;

Console.WriteLine("~ Program 1");
int[] numberList = { 1, 2, 3, 4, 7, 9, 2, 4 };
int[] repeatingNumbers = new int[numberList.Length];

for (int i = 0; i < numberList.Length; i++)
{
    int firstIndex = Array.IndexOf(numberList, numberList[i]);
    int lastIndex = Array.LastIndexOf(numberList, numberList[i]);

    /*
        Checking if element is repeated and if it is already 
        set in our 'repeatedNumbers' array.
    */
    if (firstIndex != lastIndex && 
        Array.IndexOf(repeatingNumbers, numberList[i]) == -1)
    {
        repeatingNumbers[i] = numberList[i];
    }

    // Getting repeated values that are not zero
    if (repeatingNumbers[i] != 0)
    {
        Console.Write($"[{repeatingNumbers[i]}] ");
    }
}

Console.WriteLine();
/*
    We have two sorted int arrays which could be with different sizes.
    We need to merge them in a third array while keeping this result array sorted. 
    Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries

    example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}}
             returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
*/
/*
    I believe that this program will run on O2(n ^ 2) time.
    We have two iterations and one of them is nested.
*/
Console.WriteLine();
Console.WriteLine("~ Program 2");
int[,] multiArray = new int[,]
{
    { 1, 2, 3, 4, 5},
    { 2, 5, 7, 9, 13},
};
int[] mergedArray = new int[multiArray.GetLength(1) * 2];
int nextIndex = 5;
int currentNum = 0;

for(int i = 0; i < 5; i++)
{
    mergedArray[i] = multiArray[0, i];
    mergedArray[nextIndex] = multiArray[1, i];
    nextIndex++;
}

for(int i = 0; i < mergedArray.Length; i++)
{
    for(int j = i + 1; j < mergedArray.Length; j++)
    {
        if (mergedArray[i] > mergedArray[j])
        {
            currentNum = mergedArray[i];
            mergedArray[i] = mergedArray[j];
            mergedArray[j] = currentNum;
        }
    }
    

    Console.Write(mergedArray[i] + " ");
}

// Using the Sort() method below, cuts down our iterations.
/*
    Array.Sort(mergedArray);
    string sortedNumbers = String.Join(", ", mergedArray);
    Console.WriteLine(sortedNumbers);
*/
Console.WriteLine();

/*
    Given an integer, reverse the digits of that integer, e. g. 
    input is 3415, output is 5143. What is the time complexity of 
    your solution? 
*/

/*
    Since we are only iterating once, I belive 
    the complexity of this program is O(n)
*/

/*
    Solution inspiration from:
    https://www.javatpoint.com/csharp-program-to-reverse-number
*/
Console.WriteLine();
Console.WriteLine("~ Program 3");

Console.WriteLine("~ Please enter a number of AT LEAST 4 digits: ");
int userInt = Int32.Parse(Console.ReadLine());
int remainder = 0;
int reverse = 0;

while(userInt > 0)
{
    remainder = userInt % 10;
    reverse = reverse * 10 + remainder;
    userInt /= 10;
}

Console.WriteLine($"Reversed output: {reverse}");