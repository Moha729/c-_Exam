using System;

public class Program {

    public static void Main(string[] args){

        System.Console.WriteLine("Welcome");

        Market market = new();
        market.goToCart();
    }
}