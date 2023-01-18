/*
    List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a 
    List of Lists of Integers. It returns a new list with each element 
    representing the maximum number found in the corresponding original list. 

    For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}. 
    Output the results with a message like: “List 1 has a maximum of 5. 
    List 2 has a maximum of 9. List 3 has a maximum of 2.”
*/
/*
    I beleive this solution to be O(n) since I are only 
    visiting the list once but with three iterations.
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

/*
    String HighestGrade(List<List<int>>) accepts a list of number 
    grades among students in different courses (where each list 
    represents a single course), between 0 and 100. It returns the highest 
    grade among all students in all courses.

    For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } returns 
    "The highest grade is 95. This grade was found in class(es) {index}".
*/
/*
    I beleive this solution to be O(n) since I am only 
    iterating through every list once. This is because I am
    using the 'Max()' method in both lists. Which means I am likely
    iterating through these lists.
*/
Console.WriteLine();
Console.WriteLine("~ Program 2");
List<List<int>> grades = new List<List<int>>();
grades.Add(new List<int>() { 85, 92, 67, 94, 94 });
grades.Add(new List<int>() { 50, 60, 57, 95 });
int firstMaxGrade = grades[0].Max();
int secondMaxGrade = grades[1].Max();

if (firstListMax > secondListMax)
{
    Console.WriteLine($"The highest grade is {firstMaxGrade}. This grade was found in Class 1");
}

if (firstListMax < secondListMax)
{
    Console.WriteLine($"The highest grade is {secondMaxGrade}. This grade was found in Class 2");
}

/*
    List<int> OrderByLooping (List<int>) orders a list of integers, 
    from least to greatest, using only basic control statements 
    (ie. if/else, for/while).

    For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}. 
*/
/*
    I believe this solution to be O(n ^ 2). I have two initial iterations,
    but one of those iterations contains a nested loop!

    I take no credit of the solution below.
    All credit is due to Karthikeya Boyini.
    https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash
*/
Console.WriteLine();
Console.WriteLine("~ Program 3");
List<int> myNumbers = new List<int>();
myNumbers.AddRange(new List<int>() { 6, -2, 5, 3 });

int current;
for (int j = 0; j <= myNumbers.Count() - 2; j++)
{
    for (int i = 0; i <= myNumbers.Count() - 2; i++)
    {
        if (myNumbers[i] > myNumbers[i + 1])
        {
            current = myNumbers[i + 1];
            myNumbers[i + 1] = myNumbers[i];
            myNumbers[i] = current;
        }
    }
}

Console.WriteLine($"Sorted List: {String.Join(", ", myNumbers)}");
