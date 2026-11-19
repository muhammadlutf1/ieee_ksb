IFlyable duck1 = new Duck();
ISwimmable duck2 = new Duck();
IWalkable duck3 = new Duck();

Console.WriteLine($"duck1: {duck1.Move()}");
Console.WriteLine($"duck2: {duck2.Move()}");
Console.WriteLine($"duck3: {duck3.Move()}");

public interface IFlyable
{
    public string Move();
}

public interface ISwimmable
{
    public string Move();
}

public interface IWalkable
{
    public string Move();
}

public class Duck : IFlyable, ISwimmable, IWalkable
{
    string IFlyable.Move() => "flying";
    string ISwimmable.Move() => "swimming";
    string IWalkable.Move() => "walking";
}