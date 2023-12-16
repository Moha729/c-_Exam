
using System;

public class Product{

    public string Ean { set; get;}
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }


    public Product(string ean, string name, decimal price, string category)
    {
        Ean = ean;
        Name = name;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"Product Ean: {Ean}, Name: {Name}, Price: {Price}, Category: {Category}";
    }
}