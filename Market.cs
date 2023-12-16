
using System;

public class Market {

        public List<Product> products { set; get;}

    public Market () {
            products = new(){
            new Product("a", "Apple", 0.50m, "Fruits"),
            new Product("b", "Bread", 1.00m, "Bakery"),
            new Product("c", "Carrot", 0.30m, "Vegetables"),
            new Product("d", "Milk", 0.99m, "Dairy"),
            new Product("e", "Eggs", 2.50m, "Dairy"),
            new Product("f", "Flour", 1.20m, "Bakery"),
            new Product("g", "Grapes", 2.00m, "Fruits"),
            new Product("h", "Honey", 3.50m, "Sweeteners"),
            new Product("i", "Ice Cream", 4.00m, "Frozen Foods"),
            new Product("j", "Juice", 1.50m, "Beverages"),
            new Product("k", "Ketchup", 1.75m, "Condiments")    
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


    public List<Product> goToCart(){
        string input;
        List<Product> productsInCart = new();
        do
        {
            Product product = selectItem();
            Product product1 = new(product.Ean, product.Name, product.Price, product.Category);
            productsInCart.Add(product1);
            Console.WriteLine("Enter 0 to exit");
            input = Console.ReadLine();
        } while (input != "0");

        displayCart(productsInCart);
        return productsInCart;
    }

    public void displayCart(List<Product> products){
        Console.WriteLine("Your product list is: ");
        foreach (Product product in products){
            Console.WriteLine(product);
        }
    }
}

