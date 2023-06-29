

using ClassMethotDemo.cs;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Name = "sıla";
            costumer1.Adress = "ümraniye";
            costumer1.ID = 2345;
            costumer1.Age = 20;

            Costumer costumer2 = new Costumer();
            costumer2.Name = "ali";
            costumer2.Adress = "kısıklı";
            costumer2.ID = 0000;
            costumer2.Age = 21;

            Costumer costumer3 = new Costumer();
            costumer3.Name = "ebrar";
            costumer3.Adress="bahcelievler";
            costumer3.ID = 9876;
            costumer3.Age = 23;

            Costumer costumer4 = new Costumer();
            costumer4.Name = "emirhan";
            costumer4.Adress = "atakent";
            costumer4.ID = 0000000;
            costumer4.Age = 2;

            Costumer[] costumers = new Costumer[] { costumer2, costumer1, costumer3, costumer4 };
            foreach (var costumer in costumers)
            {
                Console.WriteLine("tebrikler"+":"+costumer.Name);
            }


            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Delete(costumer2);
            costumerManager.Update(costumer3);
            costumerManager.Delete(costumer4);


            



               



        }




    }





}
