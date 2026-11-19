Animal animal = new Dog();

animal.Speak(); // late binding. `Speak` is a virtual method
animal.Type(); // early binding

object text = "hello";
Printer.Print(text); // early binding `Print(object obj)`
Printer.Print((dynamic)text); // late binding. Dynamic type is decided in runtime
    
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("I am an animal, and speaking somehow");
    }

    public void Type()
    {
        Console.WriteLine("Animal");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("*Barking*");
    }
    
    public new void Type()
    {
        Console.WriteLine("Dog");
    }
}

public static class Printer
{
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }

    public static void Print(object obj)
    {
        Console.WriteLine(obj.GetType());
    }
}