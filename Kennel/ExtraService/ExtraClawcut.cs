using Kennel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.ExtraService
{
    public class ExtraClawcut : IExtraClawcut
    {
        public string Name => "Claws cut";

        public double Price => 50.00;

        public bool TrueOrFalse { get; set; }
        public IDbLists Db { get; set; }

        public ExtraClawcut(IDbLists db)
        {
            TrueOrFalse = false;
            Db = db;
        }

        public void AddExtraService()
        {
            Console.Clear();
            Console.WriteLine("Listing checked-in animals:");
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].IsHere)
                {
                    Console.WriteLine($"{i}-{Db.AnimalList[i].Name}");
                }
            }
            Console.WriteLine("Choose the animal you want to get claws done:");
            int intAnimal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You added claw clipping to {Db.AnimalList[intAnimal].Name} for {Price} USD");
            Db.AnimalList[intAnimal].Price += Price;
            TrueOrFalse = true;
            Db.AnimalList[intAnimal].ExtraServices.Add(this);
            Console.WriteLine("Press Enter to return to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
