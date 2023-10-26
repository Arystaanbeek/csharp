using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class Supermarket
{
    public Product[] products;

    public Supermarket()
    {
        // Initialize the list of products in the supermarket
        products = new Product[]
        {
            new Product("Milk", 2.5),
            new Product("Bread", 1.0),
            new Product("Eggs", 1.8),
            // Add other products
        };
    }

    public double CalculateTotalPrice(string[] selectedProducts)
    {
        double totalPrice = 0;
        DateTime currentTime = DateTime.Now;

        foreach (string productName in selectedProducts)
        {
            Product product = Array.Find(products, p => p.Name == productName);

            if (product != null)
            {
                // Check the time and provide a 5% discount from 8:00 to 12:00
                if (currentTime.Hour >= 8 && currentTime.Hour < 12)
                {
                    totalPrice += product.Price * 0.95;
                }
                else
                {
                    totalPrice += product.Price;
                }
            }
            else
            {
                Console.WriteLine($"Product {productName} not found in the store.");
            }
        }

        return totalPrice;
    }
}

class Task2
{
    static void Main()
    {
        Supermarket supermarket = new Supermarket();

        Console.WriteLine("Available products:");
        foreach (Product product in supermarket.products)
        {
            Console.WriteLine($"{product.Name} - {product.Price:C}");
        }

        Console.Write("Enter a list of products separated by a comma: ");
        string input = Console.ReadLine();
        string[] selectedProducts = input.Split(',');

        double totalPrice = supermarket.CalculateTotalPrice(selectedProducts);

        Console.WriteLine($"Total purchase amount: {totalPrice:C}");
    }
}
