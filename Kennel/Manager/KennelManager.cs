using Kennel.Classes;
using Kennel.Data;
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
        public IExtraServices ExtraServices { get; set; }

        public KennelManager(IDbLists db, IExtraServices extraServices)
        {
            Db = db;
            ExtraServices = extraServices;
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
            if (Db.AnimalList[animal].GotClawcut) { Console.WriteLine("Claw cut: 50 USD"); }
            if (Db.AnimalList[animal].GotHaircut) { Console.WriteLine("Hair cut: 50 USD"); }
            Console.WriteLine($"Total price: {Db.AnimalList[animal].Price} USD");
            Console.WriteLine("--------------");
            Db.AnimalList[animal].GotClawcut = false;
            Db.AnimalList[animal].GotHaircut = false;
            Console.ReadLine();
            Console.Clear();
        }

        public void AddHaircut()
        {
            Console.Clear();
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{i}-{Db.AnimalList[i].Name}");
                }
            }
            Console.WriteLine("Select the animal you want to haircut");
            int animal = Convert.ToInt32(Console.ReadLine());
            ExtraServices.AddHaircut(animal);
            Console.WriteLine($"Haircut added to {Db.AnimalList[animal].Name}");
            Console.WriteLine("Press Enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }

        public void AddClawcut()
        {
            Console.Clear();
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{i}-{Db.AnimalList[i].Name}");
                }
            }
            Console.WriteLine("Select the animal you want to clawcut");
            int animal = Convert.ToInt32(Console.ReadLine());
            ExtraServices.AddHaircut(animal);
            Console.WriteLine($"Clawcut added to {Db.AnimalList[animal].Name}");
            Console.WriteLine("Press Enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
