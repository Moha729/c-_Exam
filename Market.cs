
using System;

public class Market {

        public List<Product> products { set; get;}

    public Market () {
            products = new(){
            new Product("a", "Apple", 0.50m, "Fruits"),
            new Product("b", "Bread", 1.00m, "Bakery")
        };
    }

    public void displayItems(){
        foreach (Product product in products){
            System.Console.WriteLine(product);
        }
    }

    public Product selectItem(){
        displayItems();
        string eanNo = Console.ReadLine();

        foreach (Product product in products)
        {
            if (product.Ean == eanNo)
            {
                return product;
            }
        }

        return null; 
    }

    public List<Product> selectQuantity(Product product){
        
        if (product == null) return new List<Product>();
        
        System.Console.WriteLine("enter quantity");
        if (int.TryParse(Console.ReadLine(), out int quan))
        {
            List<Product> amount = new();
            for (int i = 0; i < quan; i++)
            {
                amount.Add(product);
            }
            return amount;
            
        } else {
            return new List<Product>();
        }
        
    }

    public List<Product> goToCart(){
        string input;
        List<Product> productsInCart = new();
        do
        {
            productsInCart.AddRange(selectQuantity(selectItem()));
            System.Console.WriteLine("Enter 0 to exit");
            input = Console.ReadLine();
        } while (input != "0");

        displayCart(products);
        return productsInCart;
    }

    public void displayCart(List<Product> products){
        foreach (Product product in products){
            System.Console.WriteLine(product);
        }
    }
}

