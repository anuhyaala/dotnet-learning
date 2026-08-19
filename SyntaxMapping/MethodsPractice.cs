class MethodsPractice
{
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void ChangeNumber(ref int number)
    {
        number = 100;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }


public static void Calculate(int a, int b, out int sum, out int difference)
{
    sum = a + b;
    difference = a - b;
}

public static void PrintNumber(in int number)
    {
        Console.WriteLine($"Number: {number}");
    }

public static (int sum, int difference) CalculateWithTuple(int a, int b)
    {
        return(a+b,a-b);
    }

public static void UpdateMarks(ref int marks)
    {
        marks += 5;
    }
public static void GetGrade(int marks, out char grade)
    {
        if (marks >= 90)
        {
            grade = 'A';
        }
        else if (marks >= 75)
        {
            grade = 'B';
        }
        else if (marks >= 50)
        {
            grade = 'C';
        }
        else
        {
            grade = 'F';
        }
    }
public static (string name, int marks) GetStudent()
    {
        return("Anu", 92);
    }

}


class Student
{
    public string Name = "";
}

