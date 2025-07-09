// Intelligent.cs
using System;

public class Greeter {
    private string name;

    public Greeter(string name) {
        this.name = name;
    }

    public void Greet() {
        Console.WriteLine($"Hello from {name} in C#!");
    }

    public static void Main() {
        Greeter greeter = new Greeter("Intelligent");
        greeter.Greet();
    }
}
