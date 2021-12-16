using Kennel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Classes
{
    public class ExtraServices : IExtraServices
    {

        public double Price { get; set; }
        public IDbLists Db { get; set; }

        public ExtraServices(IDbLists db)
        {
            Db = db;

        }

        public void AddHaircut(int animal)
        {
            Db.AnimalList[animal].Price += 50;
            Db.AnimalList[animal].GotHaircut = true;
        }

        public void AddClawcut(int animal)
        {
            Db.AnimalList[animal].Price += 50;
            Db.AnimalList[animal].GotClawcut = true;
        }
    }
}
