using System.Runtime.CompilerServices;

Print(10);
Print("Hello");
Print(3.14);

Box<int> numberBox = new Box<int>();
numberBox.Value = 100;

Box<string> textBox = new Box<string>();
textBox.Value = "Hello from generic class";

Console.WriteLine($"Number box: {numberBox.Value}");
Console.WriteLine($"Text box: {textBox.Value}");

Repository<string> names = new Repository<string>();

names.Add("Anu");
names.Add("Rahul");
names.Add("Priya");

Console.WriteLine();
Console.WriteLine("Repository items:");

foreach (string name in names.Get())
{
    Console.WriteLine(name);
}

bool removed = names.Remove("Rahul");

Console.WriteLine();
Console.WriteLine($"Rahul removed: {removed}");

Console.WriteLine("Repository after removal:");

foreach (string name in names.Get())
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("Delegate example:");

MessageHandler message = SayHello;

message();

message = SayGoodbye;

message();


static void Print<T>(T value)
{
    Console.WriteLine($"Value: {value}");
    Console.WriteLine($"Type: {typeof(T)}");
    Console.WriteLine();
}


static void SayHello()
{
    Console.WriteLine("Hello!");
}


static void SayGoodbye()
{
    Console.WriteLine("Goodbye!");
}



Console.WriteLine();
Console.WriteLine("Func examples:");

Func<int, int> doubleNumber = number => number * 2;

Console.WriteLine($"Double of 10: {doubleNumber(10)}");


Func<int, int, int> add = (a, b) => a + b;

Console.WriteLine($"10 + 20: {add(10, 20)}");


Func<string, int> getLength = text => text.Length;

Console.WriteLine($"Length of Hello: {getLength("Hello")}");


Console.WriteLine();
Console.WriteLine("Action examples:");

Action sayHello = () => Console.WriteLine("Hello from Action!");

sayHello();

Action<string> printName = name => Console.WriteLine($"Name: {name}");
printName("Anu");

Action<string, int> printEmployee = (name, salary) => Console.WriteLine($"{name} earns {salary}");
printEmployee("Anu", 85000);


Console.WriteLine();
Console.WriteLine("Predicate example:");

Predicate<int> isEven = number => number % 2 == 0;

Console.WriteLine($"Is 10 even? {isEven(10)}");
Console.WriteLine($"Is 7 even? {isEven(7)}");

Predicate<int> isGreaterThan50 = number => number > 50;

Console.WriteLine($"Is 80 greater than 50? {isGreaterThan50(80)}");
Console.WriteLine($"Is 30 greater than 50? {isGreaterThan50(30)}");



Console.WriteLine();
Console.WriteLine("Event example:");

Repository<string> eventRepository = new Repository<string>();

eventRepository.ItemAdded += item => Console.WriteLine($"Item added: {item}");

eventRepository.Add("Anu");
eventRepository.Add("Rahul");




delegate void MessageHandler();




class Box<T>
{
    public T? Value { get; set; }
}


class Repository<T>
{
    private List<T> items = new List<T>();

    public event Action<T>? ItemAdded;

    public void Add(T item)
    {
        items.Add(item);

        ItemAdded?.Invoke(item);
    }

    public List<T> Get()
    {
        return items;
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }
}