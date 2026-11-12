var sara = new Manager("Sara", 35, 30_000);
var omar = new Developer("Omar", 24, 20_000, "C#");
var hussein = new Developer("Hussein", 25, 23_000, "GO");

sara.AddToTeam(omar);
sara.AddToTeam(hussein);

sara.Introduce();
Console.WriteLine();
omar.Introduce();
Console.WriteLine();
hussein.Introduce();
Console.WriteLine();

sara.RaiseSalary(10);
omar.RaiseSalary(10);
hussein.RaiseSalary(10);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}, {Age} years old.");
    }
}

public class Employee: Person
{
    private static int _lastId;
    public int Id { get; }
    public decimal Salary { get; protected set; }

    public Employee(string name, int age, decimal salary): base(name, age)
    {
        Id = ++Employee._lastId;
        Salary = salary;
    }
    
    public void RaiseSalary(decimal percent)
    {
        Salary *= 1 + (percent / 100);
        Console.WriteLine($"Salary after raise: {Salary}");
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I work as an employee, ID = {Id}");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int age, decimal salary, string lang) : base(name, age, salary)
    {
        ProgrammingLanguage = lang;
    }
    
    public void Code() {}
    
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I am a Developer and I write {ProgrammingLanguage}.");
    }
}

public class Manager : Employee
{
    public List<Developer> Team { get; } = new();

    public void AddToTeam(Developer dev)
    {
        Team.Add(dev);
    }

    public Manager(string name, int age, decimal salary): base(name, age, salary) {}
    
    public void ShowTeam() {}
    
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I am a Manager and I lead {Team.Count} developers.");
    }
}