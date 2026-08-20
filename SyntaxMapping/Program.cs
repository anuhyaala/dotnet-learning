// string name = "Anu";
// int age = 25;
// double height = 5.4;
// bool isLearningCSharp = true;
// char grade = 'A';

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(height);
// Console.WriteLine(isLearningCSharp);
// Console.WriteLine(grade);

// string name = "Anu";
// int age = 25;
// double height = 5.4;
// bool isLearningCSharp = true;
// char grade = 'A';

// Console.WriteLine($"Name: {name}");
// Console.WriteLine($"Age: {age}");
// Console.WriteLine($"Height: {height}");
// Console.WriteLine($"Learning C#: {isLearningCSharp}");
// Console.WriteLine($"Grade: {grade}");


// int a = 10;
// int b = 3;

// Console.WriteLine($"Addition: {a + b}");
// Console.WriteLine($"Subtraction: {a - b}");
// Console.WriteLine($"Multiplication: {a * b}");
// Console.WriteLine($"Division: {a / b}");
// Console.WriteLine($"Remainder: {a % b}");

// Console.WriteLine($"a is greater than b: {a > b}");
// Console.WriteLine($"a equals b: {a == b}");
// Console.WriteLine($"a is not equal to b: {a != b}");


// int age = 20;
// if (age >= 18)
// {
//     Console.WriteLine("You are an adult.");
// }
// else
// {
//     Console.WriteLine("You are not adult.");
// }


// int marks = 75;

// if (marks >= 90)
// {
//     Console.WriteLine("A");
// }
// else if (marks >= 75)
// {
//     Console.WriteLine("B");
// }
// else if (marks >= 50)
// {
//     Console.WriteLine("C");
// }
// else
// {
//     Console.WriteLine("Fail");
// }




// int day = 7;

// switch(day)
// {
//     case 1:
//        Console.WriteLine("Monday");
//        break;

//     case 2:
//        Console.WriteLine("Tuesday");
//        break;

//     case 3:
//         Console.WriteLine("Wednesday");
//         break;

//     case 4:
//     Console.WriteLine("Thursday");
//     break;

//     case 5:
//     Console.WriteLine("Friday");
//     break;

//     default:
//     Console.WriteLine("Invalid day");
//     break;

// }



// for (int i=1;i<=6;i++)
// {
//     Console.WriteLine(i);
// }


// int num = 1;

// while(num<=5)
// {
//     Console.WriteLine(num);
//     num++;
// }


// string[] names = {"Anu","Mukku","Rupa"};
// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }


// using System.Runtime.CompilerServices;

// string StudentName = "Anu";
// int Marks = 92;

// Console.WriteLine($"Student: {StudentName}");
// Console.WriteLine($"marks:{Marks}");

// if(Marks>=94)
// {
//     Console.WriteLine("Grade:A");
// }
// else if(Marks>=92)
// {
//     Console.WriteLine("Grade:B");
// }
// else if(Marks>=80)
// {
//     Console.WriteLine("Grade:C");
// }
// else
// {
//     Console.WriteLine("Grade:F");
// }

// Console.WriteLine("Numbers from 1 to 5:");

// for (int i=1; i<=5; i++)
// {
//     Console.WriteLine(i);
// }


// Console.Write("enter your name:");
// string? name = Console.ReadLine();

// Console.Write("enter your age:");
// int age = int.Parse(Console.ReadLine()!);

// Console.Write("enter your city:");
// string? city = Console.ReadLine();

// Console.WriteLine($"Hello {name}");
// Console.WriteLine($"You live in {city}");
// Console.WriteLine($"Next year you wil be {age}");


// Console.WriteLine();

// MethodsPractice.SayHello("Anu");

// int result = MethodsPractice.Add(10, 20);
// Console.WriteLine($"Addition result: {result}");

// int number = 10;

// Console.WriteLine($"Before ChangeNumber: {number}");

// MethodsPractice.ChangeNumber(ref number);

// Console.WriteLine($"After ChangeNumber: {number}");

// int x = 10;
// int y = 20;

// Console.WriteLine($"Before Swap: x = {x}, y = {y}");

// MethodsPractice.Swap(ref x, ref y);

// Console.WriteLine($"After Swap: x = {x}, y = {y}");

// int sum;
// int difference;

// MethodsPractice.Calculate(20, 25, out sum, out difference);

// Console.WriteLine($"Sum: {sum}");
// Console.WriteLine($"Difference: {difference}");

// int value = 40;

// MethodsPractice.PrintNumber(in value);

// Console.WriteLine($"Original Value: {value}");


// var (sumResult, differenceResult) = MethodsPractice.CalculateWithTuple(20,50);
// Console.WriteLine($"Tuple Sum: {sumResult}");
// Console.WriteLine($"Tuple Difference: {differenceResult}");


// Console.WriteLine();
// int a=10;
// int b=a;
// Console.WriteLine($"Before change: a = {a}, b= {b}");
// b=20;
// Console.WriteLine($"After change: a= {a}, b = {b}");


// Console.WriteLine();
// Student student1= new Student();
// student1.Name = "Anu";

// Student student2 = student1;

// Console.WriteLine($"Before change: student1 = {student1.Name}, student2 = {student2.Name}");

// student2.Name = "Ravi";

// Console.WriteLine($"After change: student1 = {student1.Name}, student2 = {student2.Name}");


// Console.WriteLine();
// int a=10;
// int b=a;
// Console.WriteLine($"Before change: a= {a}, b= {b}");
// b=20;
// Console.WriteLine($"After change: a= {a}, b= {b}");



// Console.WriteLine();
// string? userName = null;
// Console.WriteLine($"User name: {userName}");
// string displayName = userName ?? "UnKnown";
// Console.WriteLine($"Display name: {displayName}");
// userName = "Anu";
// displayName = userName ?? "UnKnown";
// Console.WriteLine($"Display name: {displayName}");


// Console.WriteLine();
// var student = MethodsPractice.GetStudent();
// Console.WriteLine($"Student: {student.name}");
// Console.WriteLine($"Original marks: {student.marks}");
// int marks = student.marks;
// MethodsPractice.UpdateMarks(ref marks);
// Console.WriteLine($"Updated marks: {marks}");
// MethodsPractice.GetGrade(marks, out char grade);
// Console.WriteLine($"Grade: {grade}");
// string? remarks = null;
// Console.WriteLine($"Remarks: {remarks ?? "No remarks"}");


// Console.WriteLine();
// int[] numbers = [10,20,30,40,50];
// Console.WriteLine($"1st number: {numbers[0]}");
// Console.WriteLine($"4th number: {numbers[3]}");
// Console.WriteLine($"Array length: {numbers.Length}");


// Console.WriteLine();
// int[] numbers = {10,20,30,40,50};
// Console.WriteLine("Numbers:");
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }
// Console.WriteLine($"Total elements: {numbers.Length}");


// Console.WriteLine();
// List<string> names =  new List<string>();
// names.Add("Anu");
// names.Add("Pallu");
// names.Add("Priya");

// Console.WriteLine("Names:");

// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }
// Console.WriteLine($"Total names: {names.Count}");
// names.Add("John");
// Console.WriteLine($"After adding John: {names.Count}");
// names.Remove("Priya");
// Console.WriteLine("After removing Priya:");
// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }


// Console.WriteLine();

// Dictionary<string, int> wordCounts = new Dictionary<string, int>();

// wordCounts["apple"] = 1;
// wordCounts["banana"] = 2;
// wordCounts["orange"] = 1;

// Console.WriteLine("Word counts:");

// foreach (KeyValuePair<string, int> item in wordCounts)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }

// Console.WriteLine($"Apple count: {wordCounts["apple"]}");

// Console.WriteLine();
// HashSet<string> names = new HashSet<string>();
// names.Add("Anu");
// names.Add("Pallu");
// names.Add("Priya");
// names.Add("Anu");
// names.Add("Pallu");
// Console.WriteLine("Unique names:");

// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }
// Console.WriteLine($"Total Unique Names: {names.Count}");

// Read the paragraph
// Console.WriteLine();
// Console.Write("Enter a paragraph:");
// string paragraph = Console.ReadLine() ?? "";
// string[] words = paragraph.Split(' ');
// Console.WriteLine();
// Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
// foreach (string word in words)
// {
//     if(wordFrequency.ContainsKey(word))
//     {
//         wordFrequency[word]++;
//     }
//     else
//     {
//         wordFrequency[word] = 1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Word Frequency:");
// foreach(KeyValuePair<string, int> item in wordFrequency)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }

using System.Runtime.CompilerServices;

Console.WriteLine();
Console.Write("Enter a paragraph:");
string paragraph = (Console.ReadLine() ?? "").ToLower();
string[] words = paragraph.Split(' ');
Console.WriteLine();
Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
foreach (string originalWord in words)
{
    string word = originalWord.Trim('.', ',', '!', '?', ';', ':');

    if(wordFrequency.ContainsKey(word))
    {
        wordFrequency[word]++;
    }
    else
    {
        wordFrequency[word] = 1;
    }
}
Console.WriteLine();
Console.WriteLine("Word Frequency:");
foreach(KeyValuePair<string, int> item in wordFrequency.OrderByDescending(item => item.Value))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}