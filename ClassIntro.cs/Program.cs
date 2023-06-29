
using System.Collections.Concurrent;

class Costumer
{
    public string CostumerName{ get; set; }
    public string CostumerPlace { get; set; }
    public int CostumerAge { get; set; }
    public int CostumerID { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Costumer costumer1 = new Costumer();
        costumer1.CostumerName = "ensar";
        costumer1.CostumerPlace = "istanbul";
        costumer1.CostumerAge = 8;
        costumer1.CostumerID = 20142023;

        Costumer costumer2 = new Costumer();
        costumer2.CostumerName = "ebrar";
        costumer2.CostumerPlace = "ankara";
        costumer2.CostumerAge = 20;
        costumer2.CostumerID = 20032023;

        Costumer costumer3 = new Costumer();
        costumer3.CostumerName = "mert";
        costumer3.CostumerPlace = "konya";
        costumer3.CostumerAge = 18;
        costumer3.CostumerID = 20052023;


        Costumer[] costumers = new Costumer[] {costumer1,costumer2,costumer3 };
        foreach(var costumer in costumers)
        {
            Console.WriteLine(costumer.CostumerName + ":"+costumer.CostumerPlace);
        }
        




    }





}

