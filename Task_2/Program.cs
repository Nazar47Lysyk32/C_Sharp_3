using System;

// Інтерфейс для сортування
public interface ISort
{
    void SortAsc();  
    void SortDesc();
}

// Клас, що реалізує інтерфейс ISort
public class SortingAlgorithm : ISort
{
    private int[] data; 

    public SortingAlgorithm(int[] array)
    {
        data = array;
    }

    public void SortAsc()
    {
        Array.Sort(data); // Вбудована функція сортування за зростанням
        Console.WriteLine("The array is sorted in ascending order.");
    }

    public void SortDesc()
    {
        Array.Sort(data);
        Array.Reverse(data); // Вбудована функція сортування та обертання для зменшення
        Console.WriteLine("The array is sorted in descending order.");
    }

    public void PrintArray()
    {
        Console.WriteLine("Array elements:");
        foreach (var item in data)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] sampleArray = { 5, 2, 8, 1, 3 };

        ISort sorter = new SortingAlgorithm(sampleArray);
        sorter.PrintArray(); // Друкуємо початковий масив

        sorter.SortAsc(); // Викликаємо метод сортування за зростанням
        sorter.PrintArray(); // Друкуємо відсортований масив

        sorter.SortDesc(); // Викликаємо метод сортування за зменшенням
        sorter.PrintArray(); // Друкуємо відсортований масив за зменшенням
    }
}
