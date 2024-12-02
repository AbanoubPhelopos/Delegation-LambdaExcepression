namespace Delegation;

public class PracticalDelegateExample
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    // Define delegate for filtering products
    public delegate bool ProductFilter(Product product);

    public static void Run()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200, Category = "Electronics" },
            new Product { Name = "Book", Price = 20, Category = "Books" },
            new Product { Name = "Smartphone", Price = 800, Category = "Electronics" },
            new Product { Name = "Coffee Mug", Price = 10, Category = "Kitchen" }
        };

        // Problem: We need different ways to filter products
        // Solution: Use delegates to create flexible filtering mechanisms

        // Using delegate method
        Console.WriteLine("Expensive Products (Price > 500):");
        FilterAndPrintProducts(products, IsExpensive);

        // Using anonymous method
        Console.WriteLine("\nElectronics Products:");
        FilterAndPrintProducts(products, delegate(Product p) {
            return p.Category == "Electronics";
        });

        // Using lambda expression
        Console.WriteLine("\nCheap Products (Price < 50):");
        FilterAndPrintProducts(products, p => p.Price < 50);
    }

    private static bool IsExpensive(Product product)
    {
        return product.Price > 500;
    }

    private static void FilterAndPrintProducts(List<Product> products, ProductFilter filter)
    {
        foreach (var product in products)
        {
            if (filter(product))
            {
                Console.WriteLine($"- {product.Name} (${product.Price})");
            }
        }
    }
}