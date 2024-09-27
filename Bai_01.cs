using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mang vua nhap: " + string.Join(", ", array));

        int[] reversedArray = array.Reverse().ToArray();
        Console.WriteLine("Mang theo chieu đao nguoc: " + string.Join(", ", reversedArray));

        var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 1);
        Console.WriteLine("Cac phan tu giong nhau và so lan xuat hien:");
        foreach (var group in duplicates)
        {
            Console.WriteLine($"Phan tu {group.Key} xuat hien {group.Count()} lan");
        }

        var uniqueElements = array.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key);
        Console.WriteLine("Cac phan tu duy nhat trong mang: " + string.Join(", ", uniqueElements));

        var evenArray = array.vx => x % 2 == 0).ToArray();
        var oddArray = array.Where(x => x % 2 != 0).ToArray();
        Console.WriteLine("Mang chan: " + string.Join(", ", evenArray));
        Console.WriteLine("Mang le: " + string.Join(", ", oddArray));

        var sortedArray = array.OrderByDescending(x => x).ToArray();
        Console.WriteLine("Mang sap xep theo thu tu giam dan: " + string.Join(", ", sortedArray));

        int max = array.Max();
        int secondMax = array.Where(x => x != max).Max();
        Console.WriteLine($"Phan tu lon thu hai trong mang: {secondMax}");
    }
}
