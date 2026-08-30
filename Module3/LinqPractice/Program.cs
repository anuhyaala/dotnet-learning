using System.IO;
using System.Text.Json;
List<Employee> employees = new List<Employee>
{
    new Employee
    {
        Name = "Anu",
        Department = "IT",
        Salary = 85000m
    },

    new Employee
    {
        Name = "Rahul",
        Department = "HR",
        Salary = 55000m
    },

    new Employee
    {
        Name = "Priya",
        Department = "IT",
        Salary = 80000m
    },

    new Employee
    {
        Name = "John",
        Department = "Sales",
        Salary = 60000m
    },

    new Employee
    {
        Name = "Sara",
        Department = "HR",
        Salary = 65000m
    },

    new Employee
    {
        Name = "David",
        Department = "IT",
        Salary = 75000m
    }
};


JsonSerializerOptions options = new JsonSerializerOptions
{
    WriteIndented = true
};
string json = JsonSerializer.Serialize(employees, options);
Console.WriteLine();
Console.WriteLine("Serialized JSON:");
Console.WriteLine(json);

string jsonFilePath = "employees.json";
File.WriteAllText(jsonFilePath, json);
Console.WriteLine();
Console.WriteLine("Employee data written to employees.json");

string jsonFromFile = File.ReadAllText(jsonFilePath);
Console.WriteLine();
Console.WriteLine("JSON read from file:");
Console.WriteLine(jsonFromFile);

List<Employee>? employeesFromFile = JsonSerializer.Deserialize<List<Employee>>(jsonFromFile);
if (employeesFromFile != null)
{
    Console.WriteLine();
    Console.WriteLine("Employees deserialized from JSON:");
foreach (Employee employee in employeesFromFile)
{
    Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Salary}");
}
}


Console.WriteLine("Employees:");

foreach (Employee employee in employees)
{
    Console.WriteLine(
        $"{employee.Name} - {employee.Department} - {employee.Salary}"
    );
}

Console.WriteLine();
Console.WriteLine("Employees with salary greater than 60000:");
var highEarners = employees.Where(employee => employee.Salary > 60000);
foreach(Employee employee in highEarners)
{
    Console.WriteLine(employee.Name);
}

Console.WriteLine();
Console.WriteLine("Employee names:");
var employeeNames = employees.Select(employee => employee.Name);
foreach(String name in employeeNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("Employees ordered by salary:");
var sortedEmployees = employees.OrderBy(employee => employee.Salary);
foreach(Employee employee in sortedEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Salary}");
}

Console.WriteLine();
Console.WriteLine("Employees grouped by department:");
var employeesByDepartment = employees.GroupBy(employee => employee.Department);
foreach(var group in employeesByDepartment)
{
    Console.WriteLine($"Department: {group.Key}");

    foreach(Employee employee in group)
    {
        Console.WriteLine($"{employee.Name} - {employee.Salary}");
    }
}

Console.WriteLine();
Console.WriteLine("Average salary by department:");
var averageSalaryByDepartment = employees.GroupBy(employee => employee.Department)
                                         .Select(group => new
                                         {
                                           Department = group.Key,
                                           averageSalary = group.Average(employee => employee.Salary)  
                                         });
foreach(var result in averageSalaryByDepartment)
{
    Console.WriteLine($"{result.Department} - {result.averageSalary}");
}

Console.WriteLine();
Console.WriteLine("Total salary by department");
var totalSalaryByDepartment = employees.GroupBy(employee => employee.Department)
                                       .Select(group => new
                                       {
                                           Department = group.Key,
                                           TotalSalary = group.Sum(employee => employee.Salary)
                                       });
foreach(var result in totalSalaryByDepartment)
{
    Console.WriteLine($"{result.Department} - {result.TotalSalary}");
}

Console.WriteLine();
Console.WriteLine("Aggregate example:");
List<int> numbers = new List<int>
{
    10,20,30,40
};
var aggregateTotal = numbers.Aggregate(0,(total,number) => total + number);
Console.WriteLine($"Aggregate total: {aggregateTotal}");

Console.WriteLine();
Console.WriteLine("Top 3 earners:");

var topThreeEarners = employees
    .OrderByDescending(employee => employee.Salary)
    .Take(3);

foreach (Employee employee in topThreeEarners)
{
    Console.WriteLine(
        $"{employee.Name} - {employee.Salary}"
    );
}

Console.WriteLine();
Console.WriteLine("Aggregate Total:");
var aggregateTotalSalary = employees.Select(Employee => Employee.Salary).Aggregate(0m,(total,salary) => total + salary);
Console.WriteLine($"Total salary: {aggregateTotalSalary}");


Console.WriteLine();
Console.WriteLine("Query syntax - employee with salary greater than 60000:");
var highSalaryEmployeesQuary = from employee in employees
                               where employee.Salary > 60000
                               select employee;
foreach (Employee employee in highSalaryEmployeesQuary)
{
    Console.WriteLine(employee.Name);
}

class Employee
{
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public decimal Salary { get; set; }
}



