using System;

// Інтерфейс для виводу інформації
public interface IOutput
{
    void Show();           
    void Show(string info); 
}

// Клас, що реалізує інтерфейс IOutput
public class ConsoleOutput : IOutput
{
    public void Show()
    {
        Console.WriteLine("Output of information without additional message.");
    }

    public void Show(string info)
    {
        Console.WriteLine($"Information output: {info}");
    }
}

class Program
{
    static void Main()
    {
        IOutput output = new ConsoleOutput();

        // Виклики методів для виводу інформації
        output.Show();
        output.Show("This is an additional message.");
    }
}
