// Employee employee1 = new Employee();

// employee1.Name = "Anuhya";
// employee1.Age = 20;

// employee1.Introduce();


// class Employee
// {
//     public string Name;
//     public int Age;

//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }
// }

// Employee employee1 = new Employee();
// employee1.Name = "Anuhya";
// employee1.Age = 21;

// employee1.Introduce();

// Employee employee2 = new Employee();

// employee2.Name = "Rupa";
// employee2.Age = 20;

// employee2.Introduce();

// class Employee
// {
//     public string Name;
//     public int Age;

//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }
// }


// Employee employee1 = new Employee();
// employee1.Name = "Anu";
// employee1.Age=  22;

// employee1.Introduce();

// Console.WriteLine(employee1.Name);
// Console.WriteLine(employee1.Age);
// class Employee
// {
//     public string Name {get; set;}
//     public int Age {get; set;}

//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }
// }



// Employee employee1 = new Employee();

// employee1.Introduce();

// class Employee
// {
//     public string Name {get; set;}
//     public int Age {get; set;}

//     public Employee()
//     {
//         Name = "Unknown";
//         Age = 0;
//     }

//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }
// }   


// Employee employee1 = new Employee("Anu",22);
// Employee employee2 = new Employee("Rupa",20);

// employee1.Introduce();
// employee2.Introduce();

// class Employee
// {
//     public string Name {get; set;}
//     public int Age {get; set;}
//     public Employee(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }

// }

// BankAccount account =  new BankAccount();

// account.AccountHolder = "Anu";
// Console.WriteLine($"Account Holder: {account.AccountHolder}");
// account.Deposit(5000);
// Console.WriteLine($"Balance: {account.Balance}");

// class BankAccount
// {
//     public string AccountHolder {get; set;}
//     private decimal balance;
//     public decimal Balance
//     {
//         get
//         {
//             return balance;
//         }
//     }
//     public void Deposit(decimal amount)
//     {
//         balance = balance + amount;
//     }
// }


// BankAccount account =  new BankAccount("Anu",5000);
// Console.WriteLine($"Account Holder: {account.AccountHolder}");
// Console.WriteLine($"Balance: {account.Balance}");
// account.Deposit(1000);
// Console.WriteLine($"Balance after deposit: {account.Balance}");
// account.Withdraw(5000);
// Console.WriteLine($"Balance after withdraw: {account.Balance}");
// account.Withdraw(2000);
// Console.WriteLine($"Balance after 2nd withdraw: {account.Balance}");
// class BankAccount
// {
//     public string AccountHolder {get; set;}
//     private decimal balance;
//     public BankAccount(string accountholder, int deposit)
//     {
//         AccountHolder = accountholder;
//         balance = deposit;
//     }
//     public decimal Balance
//     {
//         get
//         {
//             return balance;
//         }
//     }
//     public void Deposit(decimal amount)
//     {
//         balance = balance + amount;
//     }
//     public void Withdraw(decimal amount)
//     {
//         if(amount <= balance)
//         {
//             balance = balance - amount;
//         }
//         else
//         {
//             Console.WriteLine("Insufficient balance.");
//         }
//     }
// }


// Student student = new Student();

// student.Name = "Anu";

// student.Introduce();
// student.Study();


// class Person
// {
//     public string Name { get; set; }

//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name}.");
//     }
// }


// class Student : Person
// {
//     public void Study()
//     {
//         Console.WriteLine("I am studying.");
//     }
// }



// Student student = new Student("Anu");

// student.Introduce();
// student.Study();


// class Person
// {
//     public string Name { get; set; }
//     public Person(string name)
//     {
//        Name = name; 
//     }
//     public virtual void Introduce()
//     {
//         Console.WriteLine($"My name is {Name}. I am a person");
//     }
// }

// class Student : Person
// {
//     public Student(string name) : base(name)
//     {     
//     }
//     public override void Introduce()
//     {
//         Console.WriteLine($"My name is {Name}. I am a student.");
//     }

//     public void Study()
//     {
//         Console.WriteLine("I am studying.");
//     }
// }

// Person person = new Student("Anu");
// person.Introduce();

// class Person
// {
//     public string Name {get; set;}
//     public Person(string name)
//     {
//         Name = name;
//     }
//     public virtual void Introduce()
//     {
//         Console.WriteLine($"My name is {Name}. I am a person.");
//     }
// }
// class Student : Person
// {
//     public Student(string name) : base(name)
//     {
//     }
//     public override void Introduce()
//     {
//         Console.WriteLine($"My name is {Name}. I am a student");
//     }
//     public void Study()
//     {
//         Console.WriteLine("I am studying.");
//     }
// }


// Circle circle = new Circle(5);
// Console.WriteLine($"Area: {circle.CalculateArea()}");
// Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
// interface IShape
// {
//     double CalculateArea();
//     double CalculatePerimeter();
// }

// class Circle : IShape
// {
//     public double Radius {get; set;}
//     public Circle(double radius)
//     {
//         Radius = radius;
//     }
//     public double CalculateArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
//     public double CalculatePerimeter()
//     {
//         return 2 * Math.PI * Radius;
//     }
// }

// Rectangle rectangle = new Rectangle(10,5);
// Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
// Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");

// interface IShape
// {
//     double CalculateArea();
//     double CalculatePerimeter();
// }

// class Rectangle : IShape
// {
//     public double Width {get; set;}
//     public double Height {get; set;}
//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }
//     public double CalculateArea()
//     {
//         return Width * Height;
//     }
//     public double CalculatePerimeter()
//     {
//         return 2 * (Width+Height);
//     }
// }

// Triangle triangle = new Triangle(6,4,5,5,6);
// Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
// Console.WriteLine($"Triangle perimeter: {triangle.CalculatePerimeter()}");

// interface IShape
// {
//     double CalculateArea();
//     double CalculatePerimeter();
// }

// class Triangle : IShape
// {
//     public double Base {get; set;}
//     public double Height {get; set;}
//     public double Side1 {get; set;}
//     public double Side2 {get; set;}
//     public double Side3 {get; set;}
//     public Triangle(double baselength, double height, double side1, double side2, double side3)
//     {
//         Base = baselength;
//         Height = height;
//         Side1 = side1;
//         Side2 = side2;
//         Side3 = side3;
//     }
//     public double CalculateArea()
// {
//     return (Base * Height) / 2;
// }
// public double CalculatePerimeter()
// {
//     return Side1 + Side2 + Side3;
// }
// }

// List<IShape> shapes = new List<IShape>();

// shapes.Add(new Circle(5));
// shapes.Add(new Rectangle(10, 5));
// shapes.Add(new Triangle(6, 4, 5, 5, 6));
// shapes.Add(new Pentagon(5));

// foreach (IShape shape in shapes)
// {
//     Console.WriteLine($"Area: {shape.CalculateArea()}");
//     Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
//     Console.WriteLine();
// }


// interface IShape
// {
//     double CalculateArea();
//     double CalculatePerimeter();
// }


// class Circle : IShape
// {
//     public double Radius { get; set; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public double CalculateArea()
//     {
//         return Math.PI * Radius * Radius;
//     }

//     public double CalculatePerimeter()
//     {
//         return 2 * Math.PI * Radius;
//     }
// }


// class Rectangle : IShape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }

//     public double CalculateArea()
//     {
//         return Width * Height;
//     }

//     public double CalculatePerimeter()
//     {
//         return 2 * (Width + Height);
//     }
// }


// class Triangle : IShape
// {
//     public double Base { get; set; }
//     public double Height { get; set; }
//     public double Side1 { get; set; }
//     public double Side2 { get; set; }
//     public double Side3 { get; set; }

//     public Triangle(
//         double baseLength,
//         double height,
//         double side1,
//         double side2,
//         double side3)
//     {
//         Base = baseLength;
//         Height = height;
//         Side1 = side1;
//         Side2 = side2;
//         Side3 = side3;
//     }

//     public double CalculateArea()
//     {
//         return (Base * Height) / 2;
//     }

//     public double CalculatePerimeter()
//     {
//         return Side1 + Side2 + Side3;
//     }
// }

// class Pentagon : IShape
// {
//     public double Side {get; set;}
//     public Pentagon(double side)
//     {
//         Side = side;
//     }
//     public double CalculateArea()
//     {
//         return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Side * Side;
//     }
//     public double CalculatePerimeter()
//     {
//         return 5 * Side;
//     }
// }



// Animal dog =  new Dog();
// dog.MakeSound();

// abstract class Animal
// {
//     public abstract void MakeSound();
// }
// class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Dog barks.");
//     }
// }

// Dog dog =  new Dog();
// dog.Bark();
// sealed class Dog
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog Barks.");
//     }
// }


// try
// {
//     int number = int.Parse("Hello");
//     Console.WriteLine(number);
// }
// catch
// {
//     Console.WriteLine("Invalid number.");
// }

// try
// {
//     Console.WriteLine("Inside try.");
// }
// catch
// {
//     Console.WriteLine("Something went wrong.");
// }
// finally
// {
//     Console.WriteLine("Finally runs.");
// }

// try
// {
//     int number = int.Parse("Hello");
//     Console.WriteLine(number);
// }
// catch
// {
//     Console.WriteLine("Invalid number.");
// }
// finally
// {
//     Console.WriteLine("Finally runs.");
// }


// try
// {
//     throw new InsufficientFundsException("Insufficient funds.");
// }
// catch (InsufficientFundsException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// class InsufficientFundsException : Exception
// {
//     public InsufficientFundsException(String message)
//        : base(message)
//     {
        
//     }
// }


// BankAccount account =new BankAccount("Anu",5000);
// Console.WriteLine($"Account Holder: {account.AccountHolder}");
// Console.WriteLine($"Balance: {account.Balance}");
// account.Deposit(1000);
// Console.WriteLine($"Balance after deposit: {account.Balance}");
// account.Withdraw(5000);
// Console.WriteLine($"Balance after withdraw: {account.Balance}");

// try
// {
//     account.Withdraw(2000);
// }
// catch (InsufficientFundsException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// class BankAccount
// {
//     public string AccountHolder {get; set;}
//     private decimal balance;
//     public BankAccount(string accountholder,decimal initialbalance)
//     {
//         AccountHolder = accountholder;
//         balance = initialbalance;
//     }
//     public decimal Balance
//     {
//       get
//         {
//             return balance;
//         }  
//     }
//     public void Deposit(decimal amount)
//     {
//         balance = balance + amount;
//     }
//     public void Withdraw(decimal amount)
//     {
//         if (amount > balance)
//         {
//             throw new InsufficientFundsException("Insufficient funds.");
//         }
//         balance = balance - amount;
//     }
//     }
// class InsufficientFundsException : Exception
// {
//     public InsufficientFundsException(string message)
//         : base(message)
//     {
//     }
// }


using (StreamWriter writer = new StreamWriter("test.txt"))
{
    writer.WriteLine("Hello from c#");
}
Console.WriteLine("File writing completed.");