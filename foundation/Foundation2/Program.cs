using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Online Orders");

        // Create instances for Order 1
        Customer cust1 = new();
        Product cust1Prod1 = new();
        Product cust1Prod2 = new();
        Product cust1Prod3 = new();
        Order order1 = new();
        


        cust1.SetCustomerName("Todd Keeney");
        cust1.SetCustomerAddress("34815 Weyerhaeuser Way S", "Federal Way", "Washington", "USA");
        order1.AddCustomer(cust1);
        


        cust1Prod1.SetProductName("Backpack");
        cust1Prod1.SetProductPrice(89.74);
        cust1Prod1.SetQuantity(1);
        order1.AddProduct(cust1Prod1);
        


        cust1Prod2.SetProductName("Insect Repellent");
        cust1Prod2.SetProductPrice(7.99);
        cust1Prod2.SetQuantity(2);
        order1.AddProduct(cust1Prod2);
        


        cust1Prod3.SetProductName("Camp Chair");
        cust1Prod3.SetProductPrice(40.00);
        cust1Prod3.SetQuantity(1);
        order1.AddProduct(cust1Prod3);
        Console.WriteLine();
        order1.DisplayShippingInfo();





        // Create instances for Order 2
        Customer cust2 = new();
        Product cust2Prod1 = new();
        Product cust2Prod2 = new();
        Product cust2Prod3 = new();
        Order order2 = new();
        

        cust2.SetCustomerName("Alicia Sanders");
        cust2.SetCustomerAddress("348 3 St W", "Cardston", "Alberta", "Canada");
        order2.AddCustomer(cust2);
        

        cust2Prod1.SetProductName("Suntan Lotion");
        cust2Prod1.SetProductPrice(11.79);
        cust2Prod1.SetQuantity(2);
        order2.AddProduct(cust2Prod1);
        

        cust2Prod2.SetProductName("Beach Umbrella");
        cust2Prod2.SetProductPrice(34.95);
        cust2Prod2.SetQuantity(1);
        order2.AddProduct(cust2Prod2);
        

        cust2Prod3.SetProductName("Swimsuit");
        cust2Prod3.SetProductPrice(58.78);
        cust2Prod3.SetQuantity(1);
        order2.AddProduct(cust2Prod3);
        Console.WriteLine();
        order2.DisplayShippingInfo();

    }
}