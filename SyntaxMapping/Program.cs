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


using System.Runtime.CompilerServices;

string StudentName = "Anu";
int Marks = 92;

Console.WriteLine($"Student: {StudentName}");
Console.WriteLine($"marks:{Marks}");

if(Marks>=94)
{
    Console.WriteLine("Grade:A");
}
else if(Marks>=92)
{
    Console.WriteLine("Grade:B");
}
else if(Marks>=80)
{
    Console.WriteLine("Grade:C");
}
else
{
    Console.WriteLine("Grade:F");
}

Console.WriteLine("Numbers from 1 to 5:");

for (int i=1; i<=5; i++)
{
    Console.WriteLine(i);
}