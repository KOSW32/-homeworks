using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
  
        var numbers1 = new List<int> { 5, 2, 9, 1, 6 };
        Console.WriteLine("Медіана чисел: " + FindMedian(numbers1));

    
        var words1 = new List<string> { "apple", "banana", "cherry", "date", "fig" };
        Console.WriteLine("Медіана рядків: " + FindMedian(words1));

       
        var numbers2 = new List<int> { 4, 1, 7, 9, 3, 8 };
        Console.WriteLine("Медіана чисел (парна): " + FindMedian(numbers2));

      
        var words2 = new List<string> { "apple", "banana", "cherry", "date" };
        Console.WriteLine("Медіана рядків (парна): " + FindMedian(words2));
    }

    public static object FindMedian<T>(ICollection<T> collection)
        where T : IComparable<T>
    {
        if (collection == null || collection.Count == 0)
            throw new ArgumentException("Колекція порожня");

        var sorted = collection.OrderBy(x => x).ToList();
        int count = sorted.Count;
        int middle = count / 2;

        if (count % 2 != 0)
        {
            return sorted[middle];
        }

      
        T first = sorted[middle - 1];
        T second = sorted[middle];

       
        if (first is int || first is double || first is float || first is decimal)
        {
            double a = Convert.ToDouble(first);
            double b = Convert.ToDouble(second);
            return (a + b) / 2;
        }

        
        return first!;
    }
}
