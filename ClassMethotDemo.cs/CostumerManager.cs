using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo.cs
{
    internal class CostumerManager
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine("costumer added" + ":" + costumer.Name + ":" + costumer.Adress);
        }
        public void Delete(Costumer costumer)
        {
            Console.WriteLine("costumer deleted" + ":" + costumer.Adress + ":" + costumer.Age);
        }
        
        public void Update(Costumer costumer)
        {
            Console.WriteLine("consumer updated"+":"+costumer.Name+":"+costumer.Age);
        }


           
            

    }
}
