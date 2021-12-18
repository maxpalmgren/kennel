using Kennel.Classes;
using Kennel.Data;
using Kennel.ExtraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Manager
{
    public class KennelManager : IKennelManager
    {
        public IDbLists Db { get; set; }

        public KennelManager(IDbLists db)
        {
            Db = db;
        }

        public void DropOffAnimal()
        {
            Console.Clear();

            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (!Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{i}-{Db.AnimalList[i].Name}");
                }
            }
            Console.WriteLine("Select the animal you want to drop off here");
            int animal = Convert.ToInt32(Console.ReadLine());
            Db.AnimalList[animal].IsHere = true;
            Db.AnimalList[animal].Price = 100.00;
            Console.Clear();
        }

        public void PickUpAnimal()
        {
            Console.Clear();
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{i}-{Db.AnimalList[i].Name}");
                }
            }
            Console.WriteLine("Select the animal you want to Check out");
            int animal = Convert.ToInt32(Console.ReadLine());
            Db.AnimalList[animal].IsHere = false;
            Console.Clear();
            Console.WriteLine($"You've checked out {Db.AnimalList[animal].Name}");
            Console.WriteLine("Press Enter for receipt");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("----Receipt----");
            Console.WriteLine("1 day at Kennel: 100 USD");
            foreach (var prop in Db.AnimalList[animal].ExtraServices)
            {
                Console.WriteLine($"{prop.Name}: {prop.Price} USD");
            }
            Console.WriteLine($"Total price: {Db.AnimalList[animal].Price} USD");
            Console.WriteLine("--------------");
            //Db.AnimalList[animal].GotClawcut = false;
            //Db.AnimalList[animal].GotHaircut = false;
            Console.ReadLine();
            Console.Clear();
        }       
    }
}
