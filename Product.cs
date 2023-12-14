
public class Product {

    public string Name {get; set;}
    public string EAN {get; set;}

    public float Price {get; set;}


    public Product (string ean, string name, float price){
        Name = name;
        Price = price;
        EAN = ean;
    }

    public void DisplayInfo(){
        Console.WriteLine(toString());
    }

    public string toString(){
        return ($"EAN: {EAN}, Name: {Name}, Price: {Price} $");
    }
}