

class Product
{
    public static int Length { get; internal set; }
    public string gender  { get; set; }
    public int DiscountRate { get; set; }
    public string color { get; set; }
    public string clothe { set; get; }
}

 class Program
{ 
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.gender = "man";
        product1.clothe = "shirt";
        product1.DiscountRate = 10;
        product1.color = "black";

        Product product2 = new Product();
        product2.gender = "woman";
        product2.clothe = "skirt";
        product2.DiscountRate = 15;
        product2.color = "pink";

        Product product3 = new Product();
        product3.gender = "woman";
        product3.clothe = "shirt";
        product3.DiscountRate = 0;
        product3.color = "jean";

        Product[] products = new Product[] { product1, product2, product3 };
        
        foreach (var product in products)
        {
            Console.WriteLine(product.gender + ":" + product.color);
        }

        int i = 3;
        while (i < products.Length)
        {
            Console.WriteLine(products[i].DiscountRate + ":" + products[i].clothe);
        }

    } }
