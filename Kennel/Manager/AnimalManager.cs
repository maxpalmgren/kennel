using Kennel.Classes;
using Kennel.Data;
using Kennel.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Manager
{
    public class AnimalManager : IAnimalManager
    {
        public IDbLists Db { get; set; }
        public AnimalManager(IDbLists db)
        {
            Db = db;
        }

        public void CreateAnimal()
        {
            IAnimal animal = AnimalFactory.Create();
            Console.WriteLine("Write your Dogs name:");
            animal.Name = Console.ReadLine();
            for (int i = 0; i < Db.PersonList.Count; i++)
            {
                var owner = Db.PersonList[i].Name;
                Console.WriteLine($"{i}-{owner}");
            }
            Console.WriteLine($"Choose Owner to {animal.Name} with the number");
            var dogOwner = Convert.ToInt32(Console.ReadLine());
            animal.Owner = Db.PersonList[dogOwner];
            Db.AnimalList.Add(animal);
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListAnimal()
        {
            foreach (var animal in Db.AnimalList)
            {
                Console.WriteLine($"{animal.Name} is owned by {animal.Owner.Name}");
            }
            Console.WriteLine("Press enter to go back to the main menu");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListCheckedInAnimalsAndOwners()
        {
            Console.Clear();
            Console.WriteLine("Listing checked in animals and their owners:");
            for(int i = 0; i <Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{Db.AnimalList[i].Name} is checked in and is owned by {Db.AnimalList[i].Owner.Name}");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
