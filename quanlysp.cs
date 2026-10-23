
using System;
using System.Collections.Generic;

List<Product> products = new List<Product>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nNhap san pham thu {i + 1}:");

    Console.Write("Ten san pham: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Gia san pham: ");
    double price = double.Parse(Console.ReadLine() ?? "0");

    Product p = new Product
    {
        Name = name,
        Price = price
    };

    products.Add(p);
}

Console.WriteLine("\n DANH SACH SAN PHAM ");

foreach (Product p in products)
{
    Console.WriteLine($"Ten: {p.Name} - Gia: {p.Price:N0}");
}

public class Product
{
    public string Name { get; set; } = "";
    public double Price { get; set; }
}
