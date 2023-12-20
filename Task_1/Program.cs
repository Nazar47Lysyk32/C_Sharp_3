using System;

// Інтерфейс для двигуна
public interface IEngine
{
    void Start(); 
    void Stop();  
}

// Інтерфейс для транспортного засобу
public interface ITransportation
{
    void Move();  
    void Brake(); 
}

// Клас автомобіля, що реалізує інтерфейси IEngine та ITransportation
public class Car : IEngine, ITransportation
{
    public void Start()
    {
        Console.WriteLine("The car engine is running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car engine is stopped.");
    }

    public void Move()
    {
        Console.WriteLine("The car is moving.");
    }

    public void Brake()
    {
        Console.WriteLine("The car is stopped using the brake.");
    }
}

// Клас велосипеда, що реалізує інтерфейс ITransportation
public class Bicycle : ITransportation
{
    public void Move()
    {
        Console.WriteLine("The bicycle is moving.");
    }

    public void Brake()
    {
        Console.WriteLine("The bicycle is stopped with the brake.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Move();
        car.Brake();
        car.Stop();

        Console.WriteLine();

        Bicycle bicycle = new Bicycle();
        bicycle.Move();
        bicycle.Brake();
    }
}
