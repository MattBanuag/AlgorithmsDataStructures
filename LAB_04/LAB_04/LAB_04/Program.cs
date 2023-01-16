/*
    List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a 
    List of Lists of Integers. It returns a new list with each element 
    representing the maximum number found in the corresponding original list. 

    For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}. 
    Output the results with a message like: “List 1 has a maximum of 5. 
    List 2 has a maximum of 9. List 3 has a maximum of 2.”
*/
Console.WriteLine("~ Program 1");
List<List<int>> numberList = new List<List<int>>();
numberList.Add(new List<int>() { 1, 5, 3 });
numberList.Add(new List<int>() { 9, 7, 3, -2 });
numberList.Add(new List<int>() { 2, 1, 2 });

// List 1
Console.Write($"List 1: ");
foreach (int number in numberList[0])
{
    Console.Write($"[{number}] ");
}
int firstListMax = numberList[0].Max();
Console.WriteLine();
Console.WriteLine($"List 1 Max Value: {firstListMax}");

// List 2
Console.WriteLine();
Console.Write($"List 2: ");
foreach (int number in numberList[1])
{
    Console.Write($"[{number}] ");
}
int secondListMax = numberList[1].Max();
Console.WriteLine();
Console.WriteLine($"List 2 Max Value: {secondListMax}");

// List 3
Console.WriteLine();
Console.Write($"List 3: ");
foreach (int number in numberList[2])
{
    Console.Write($"[{number}] ");
}
int thirdListMax = numberList[2].Max();
Console.WriteLine();
Console.WriteLine($"List 3 Max Value: {thirdListMax}");