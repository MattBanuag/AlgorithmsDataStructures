/*
    We have a list of integers where elements appear either once or twice. 
    Find the elements that appeared twice in O(n) time.

    example: {1, 2, 3, 4, 7, 9, 2, 4} returns {2, 4} 
*/

/*
    I believe that this program will run on O(n) time.
    There is only one loop iterating through the array.
*/
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
        Console.Write($"{repeatingNumbers[i]}, ");
    }
}


