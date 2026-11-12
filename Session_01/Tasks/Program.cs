#region Task 1: If, else and the ternary
/*
var input = Console.ReadLine();

var isIeee = string.Equals(input, "IEEE", StringComparison.OrdinalIgnoreCase);

// if/else
if (isIeee) Console.WriteLine("my name is IEEE");
else Console.WriteLine("not IEEE");

// ternary operator
Console.WriteLine(isIeee ? "my name is IEEE" : "not IEEE");
*/
#endregion

#region Task 2: Switch
/*
var day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Saturday");
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Wednesday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}
*/
#endregion

#region Task 3, 4
/*
#region Task 3: Shallow copy, predict first
// Person p1 = new Person(1, "Ahmed");
// Person p2 = new Person(2, "Ali");
// p1 = p2; // assignment by reference
// now p1, p2 both refer to the same 'Person(2, "Ali")' on heap
// p1.Name = "Omer";
// Console.WriteLine(p1); // Omer
// Console.WriteLine(p2); // Omer
#endregion

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Person (int id , string  name )
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"ID :{Id} :: Name : {Name}";
    }

    #region Task 4: Deep copy with Clone
    public Person Clone()
    {
        return new Person(Id, Name);
    }
    #endregion
}
*/
#endregion

#region Task 5: Comparison operators and a bug hunt
/*
Console.WriteLine("X:");
var x = int.Parse(Console.ReadLine());
Console.WriteLine("X:");
var y = int.Parse(Console.ReadLine());

if (x == y) Console.WriteLine("x == y");
else if (x > y) Console.WriteLine("x > y");
else if (x < y) Console.WriteLine("x < y");

// Can else if (y != x) .. even run ?
// No as two numbers comparision has only 3 possible results
// either x == y, x > y, x < y
*/
#endregion

#region Task 6: Arithmetic calculator
/*
Console.WriteLine("""
                  === Arithmetic calculator ===
                  Expected Input: <number> <operator> <number>
                  one space " " separator
                  """);
var line = Console.ReadLine();

var inputs = line.Split(" ");

var x = double.Parse(inputs[0]);
var y = double.Parse(inputs[2]);
var op = inputs[1];
switch (op)
{
    case "+":
        Console.WriteLine(x + y);
        break;
    case "-":
        Console.WriteLine(x - y);
        break;
    case "*":
        Console.WriteLine(x * y);
        break;
    case "/":
        Console.WriteLine(x / y);
        break;
    case "%":
        Console.WriteLine(x % y);
        break;
    default:
        Console.WriteLine($"Unknown Operator '{op}'");
        break;
}

// Explain in one line why 2 / 4 prints 0 but (double) 2 / 4 prints 0.5 ?
// an int / int operation expected result is an int so the value is truncated
// 0.5 -> 0
// 1.5 -> 1
*/
#endregion

#region Task 7: Logical operators challenge
/*
Console.WriteLine(Task_7.IsLeapYear(1900));
Console.WriteLine(Task_7.IsLeapYear(2000));
Console.WriteLine(Task_7.IsLeapYear(2024));

public static class Task_7 {
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }
    
    public static string GetGrade(int mark)
    {
        if (mark > 100 || mark < 0) return "Only 0:100 range";
        
        if (mark <= 100 && mark >= 90) return "A";
        else if (mark < 90 && mark >= 80) return "B";
        else if (mark <= 80 && mark >= 70) return "C";
        else if (mark <= 70 && mark >= 60) return "D";
        else return "F";
    }
}
*/
#endregion