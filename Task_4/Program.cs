using System;

// Інтерфейс для виводу інформації
public interface IOutput
{
    void Show();           
    void Show(string info); 
}

// Інтерфейс для математичних операцій
public interface IMath
{
    int Sum();      
    double Average(); 
}

// Інтерфейс для сортування
public interface ISort
{
    void SortAsc(); 
    void SortDesc(); 
}

// Клас для масиву цілих чисел, що імплементує інтерфейси IOutput, IMath та ISort
public class MyArray : IOutput, IMath, ISort
{
    private int[] data;

    public MyArray(int[] array)
    {
        data = array;
    }

    // IOutput
    public void Show()
    {
        Console.Write("Massif: ");
        foreach (var item in data)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine($"Massif: {info}");
        Show();
    }

    // IMath
    public int Sum()
    {
        int sum = 0;
        foreach (var item in data)
        {
            sum += item;
        }
        return sum;
    }

    public double Average()
    {
        if (data.Length == 0)
            return 0;

        return (double)Sum() / data.Length;
    }

    // ISort
    public void SortAsc()
    {
        Array.Sort(data);
    }

    public void SortDesc()
    {
        Array.Sort(data);
        Array.Reverse(data);
    }
}

class Program
{
    static void Main()
    {
        int[] sampleArray = { 5, 2, 8, 1, 3 };

        MyArray myArray = new MyArray(sampleArray);

        // IOutput
        myArray.Show();
        myArray.Show("This is an additional message.");

        // IMath
        Console.WriteLine($"Sum of elements: {myArray.Sum()}");
        Console.WriteLine($"Arithmetic mean: {myArray.Average()}");

        // ISort
        Console.WriteLine("Sorted array by growth:");
        myArray.SortAsc();
        myArray.Show();

        Console.WriteLine("Sorted array in descending order:");
        myArray.SortDesc();
        myArray.Show();
    }
}
