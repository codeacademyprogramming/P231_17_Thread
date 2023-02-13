// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


double price = 60;
Console.WriteLine(price);

Product pr = new Product();

Student student = new Student();

Car mercedes = new Car("E200",56400);

Product newProduct = new Product
{
    Name = "Milla"
};


class Product
{
    public Product()
    {
        Price = 56;
    }
    public string Name { get; init; }
    public double Price { get; private set; }  
    
    public void ApllyDiscount(double percent)
    {
        Price = Price * (100 - percent) / 100;
    }
}

record Car(string Name, double Price);
